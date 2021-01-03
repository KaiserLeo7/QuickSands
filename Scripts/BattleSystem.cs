using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace Sands
{
    public enum BattleState { START, PLAYERTURN, PLAYERBUSY, ENEMYTURN, ENEMYBUSY, WON, LOST }

    public class BattleSystem : MonoBehaviour
    {

        //Serialized means it is visible to the Inspector
        [SerializeField] private Transform prefabCharacter;
        [SerializeField] private Transform prefabEnemyCharacter;

        private CharAction playerCharAction;
        private CharAction enemyCharAction;

        //////////////////////////////

        public Transform playerBattleStation;
        public Transform enemyBattleStation;

        Hero playerUnit;
        Hero enemyUnit;

        public BattleHUD playerHUD;
        public BattleHUD enemyHUD;

        public Text dialogueText;

        //////////////////////////////

        public BattleState battleState;

        private CharAnimation playerAnim;

        private CharAction charAction;

        private CharAction playerChar;
        private CharAction enemyChar;

        private CharAction activeChar;

        //////////////////////////////

        public static BattleSystem instance;

        public static BattleSystem GetInstance()
        {
            return instance;
        }

        // Start is called before the first frame update
        private void Awake()
        {
            instance = this;
        }

        void Start()
        {
            battleState = BattleState.START;

            StartCoroutine(SetupBattle());
        }

        private void Update()
        {

        }

        /// /// /// /// /// /// /// SETUP/SPAWN/TURN /// /// /// /// /// /// /// ///

        IEnumerator SetupBattle()
        {

            playerChar = SpawnCharacter(true);
            enemyChar = SpawnCharacter(false);

            //dialogue control                   
            dialogueText.text = "An enemy approaches!!";

            //update stats being displayed
            playerHUD.SetHUD(playerUnit);
            enemyHUD.SetHUD(enemyUnit);

            //wait 2 seconds
            yield return new WaitForSeconds(1f);

            //start with the players turn
            SetActiveChar(playerChar);

            StartCoroutine(PlayerTurn());
        }

        private CharAction SpawnCharacter(bool isPlayerTeam)
        {

            Transform characterTransform;

            if (isPlayerTeam)
            {
                characterTransform = Instantiate(prefabCharacter, playerBattleStation.position, Quaternion.identity);

                //assign to unit health
                playerUnit = characterTransform.GetComponent<Hero>();

            }
            else
            {
                characterTransform = Instantiate(prefabEnemyCharacter, enemyBattleStation.position, Quaternion.Euler(0, 180, 0));

                //assign to unit health
                enemyUnit = characterTransform.GetComponent<Hero>();
            }

            CharAction characterAction = characterTransform.GetComponent<CharAction>();
            characterAction.Setup(isPlayerTeam);

            return characterAction;
        }

        private void SetActiveChar(CharAction newChar)
        {
            activeChar = newChar;
        }

        private void chooseNextActiveChar()
        {
            if (battleState != BattleState.WON && battleState != BattleState.LOST)
            {
                if (activeChar == playerChar)
                {

                    SetActiveChar(enemyChar);
                    battleState = BattleState.ENEMYTURN;

                }
                else
                {

                    SetActiveChar(playerChar);
                    battleState = BattleState.PLAYERTURN;
                }
            }
        }

        /// /// /// /// /// /// /// /// PLAYER /// /// /// /// /// /// /// ///

        IEnumerator PlayerTurn()
        {
            yield return new WaitForSeconds(1f);
            battleState = BattleState.PLAYERTURN;
            dialogueText.text = "Choose an action:";
        }

        public void CalculateDamage()
        {

            if (battleState == BattleState.PLAYERBUSY)
            {

                //test to see if the enemy is still alive
                bool isEnemyDead = enemyUnit.TakeDamage(playerUnit.Damage);

                //update enemy health
                enemyHUD.SetHP(enemyUnit.CurrentHP);

                //if dead you won, if not enemy Turn
                if (isEnemyDead)
                {
                    battleState = BattleState.WON;
                    EndBattle();
                }
                else
                {
                    battleState = BattleState.ENEMYTURN;
                    StartCoroutine(EnemyTurn());
                }
            }
            else if (battleState == BattleState.ENEMYBUSY)
            {

                //test to see if the enemy is still alive
                bool isPlayerDead = playerUnit.TakeDamage(enemyUnit.Damage);

                //update enemy health
                playerHUD.SetHP(playerUnit.CurrentHP);

                //if dead you won, if not enemy Turn
                if (isPlayerDead)
                {
                    battleState = BattleState.LOST;
                    EndBattle();
                }
                else
                {

                    StartCoroutine(PlayerTurn());
                }
            }
        }

        //IEnumerator 
        public void CalculateHeal()
        {

            if (battleState == BattleState.PLAYERBUSY)
            {

                //heals player for a 4th of his health
                playerUnit.Heal(playerUnit.MaxHP / 4); // was 25

                playerHUD.SetHP(playerUnit.CurrentHP);

                //yield return new WaitForSeconds(2f);

                dialogueText.text = "You feel your strength renewed!";

                Debug.Log(dialogueText.text);

                battleState = BattleState.ENEMYTURN;
                StartCoroutine(EnemyTurn());

            }
            else if (battleState == BattleState.ENEMYTURN)
            {

                ////heals player for a 4th of his health
                //enemyUnit.Heal(enemyUnit.maxHP / 4); // was 25

                //enemyHUD.SetHP(enemyUnit.currentHP);
                //dialogueText.text = "You feel your strength renewed!";

                //// yield return new WaitForSeconds(2f);


                StartCoroutine(PlayerTurn());
            }
        }

        /// /// /// /// /// /// /// BUTTONS /// /// /// /// /// /// /// ///

        public void OnAttackButton()
        {

            if (battleState != BattleState.PLAYERTURN)
            {
                return;

            }
            else
            {

                battleState = BattleState.PLAYERBUSY;
                playerChar.Attack(enemyChar, () =>
                {
                    chooseNextActiveChar();
                });

            }
        }

        public void OnHealButton()
        {

            if (battleState != BattleState.PLAYERTURN)
            {
                return;

            }
            else
            {

                battleState = BattleState.PLAYERBUSY;
                playerChar.Heal(() =>
                {
                    chooseNextActiveChar();
                });
            }
        }

        /// /// /// /// /// /// /// ENEMY  /// ////// /// /// /// /// ///

        IEnumerator EnemyTurn()
        {

            while (battleState == BattleState.ENEMYTURN)
            {
                yield return new WaitForSeconds(2f);
                dialogueText.text = "The enemy is attacking!";

                yield return new WaitForSeconds(1f);

                //HERE YOU CAN EXPAND THE BEHAVIOUR OF THE ENEMY BASED ON % OF HEALTH OR OTHER FACTORS
                battleState = BattleState.ENEMYBUSY;

                enemyChar.Attack(playerChar, () =>
                {

                    chooseNextActiveChar();
                });
                /////////////

            }
        }

        /// /// /// /// /// /// /// END /// /// /// /// /// /// /// ///

        void EndBattle()
        {

            if (battleState == BattleState.WON)
            {
                dialogueText.text = "You won the battle!";

            }
            else if (battleState == BattleState.LOST)
            {
                dialogueText.text = "You were defeated.";
            }
        }
    }

}


//TO DO LIST
