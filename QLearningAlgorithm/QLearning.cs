using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLearningAlgorithm
{
    public class QLearningModule
    {
        private int numStates;
        private int numActions;
        public NumberTable utilityTable;
        public NumberTable utilityUpdates;
        public double totalRewardGained = 0;

        private double defaultUtility;
        private double learningRate;
        private double discountRate;

        private bool useDiscountedLearning;

        private int totalNumUpdates;

        /** A default value for the learning rate. */
        private static double DEFAULT_LEARNING_RATE = 0.5;

        /** A discount value for the discount rate. */
        private static double DEFAULT_DISCOUNT_RATE = 0.5;

        public QLearningModule(int numStates, int numActions, double pDefaultUtility) 
            : this(numStates, numActions, pDefaultUtility, false)
        {
        }

        public QLearningModule(int numStates, int numActions, double pDefaultUtility, bool pUseDicountedLearning)
            : this(numStates, numActions, pDefaultUtility, pUseDicountedLearning, DEFAULT_LEARNING_RATE, DEFAULT_DISCOUNT_RATE)
        {
        }

        public QLearningModule(int numStates, int numActions, double pDefaultUtility, bool pUseDiscountedLearning, double pLearningRate,
            double pDiscountRate)
        {
            defaultUtility = pDefaultUtility;
            useDiscountedLearning = pUseDiscountedLearning;
            discountRate = Math.Min(1.0, Math.Max(0.0, pDiscountRate));
            learningRate = useDiscountedLearning
                    ? 1.0
                    : Math.Min(1.0, Math.Max(0.0, pLearningRate));

            // set the initial values
            totalNumUpdates = 0;

            // create the collections
            utilityTable = new NumberTable(numStates, numActions, pDefaultUtility);
            utilityUpdates = new NumberTable(numStates, numActions, 0);
        }

        public void LearnUtility(int state, int nextState, int action,
            double reward)
        {
            // update the table
            UpdateUtilityTable(state, nextState, action, reward);
            totalRewardGained += reward;
        }

        public void AssignPerfectUtility(int state, int nextState, int action,
            double utility)
        {
            // assign the value to the table
            utilityTable.UpdateValue(state, action, utility);
        }

        private void UpdateUtilityTable(int state, int nextState, int action,
            double reward)
        {
            // increment the number of updates
            utilityUpdates.AddValue(state, action, 1);
            totalNumUpdates++;

            // compute the new utility in the table
            double newUtility = ComputeNewUtility(state, nextState, action,
                    reward);

            // update the table
            utilityTable.UpdateValue(state, action, newUtility);
        }

        private double ComputeNewUtility(int state, int nextState,
            int action, double reward)
        {
            // get the old utility
            double oldUtility = utilityTable.GetValue(state, action);

            // get the best next utility
            double bestNextUtility = BestUtility(nextState);

            // compute the new value
            double lRate = useDiscountedLearning
                ? learningRate / Math.Floor(utilityUpdates.GetValue(state, action))
                : learningRate;

            return oldUtility * (1 - lRate) + lRate * (reward + discountRate * bestNextUtility);
        }

        public double BestUtility(int state)
        {
            // get the best action for the  state
            int bestAction = BestAction(state);

            // find the utility for this action
            return (bestAction != null)
                    ? utilityTable.GetValue(state, bestAction)
                    : defaultUtility;
        }

        public int BestAction(int state)
        {
            // get the action which maximizes utility for this state
            return utilityTable.GetRowMaxColumn(state);
        }

        public double ExpectedUtility(int state, int action)
        {
            // grab the expected utility
            return utilityTable.GetValue(state, action);
        }

        public int GetNumberOfUpdates()
        {
            return totalNumUpdates;
        }

        public int GetNumberOfUpdates(int state, int action)
        {
            // grab the number of updates
            return (int)utilityUpdates.GetValue(state, action);
        }


    }
}
