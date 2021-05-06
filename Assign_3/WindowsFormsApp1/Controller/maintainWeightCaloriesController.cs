using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Controller
{
    class maintainWeightCaloriesController
    {
        maintainWeightCalories mwc;

        public maintainWeightCaloriesController(double weight, double height, int age)
        {
            mwc = new maintainWeightCalories(weight, height, age);
        }
        public double BMRFemale()
        {
            return mwc.BMRFemale();
        }

        public double BMRMale()
        {

            return mwc.BMRMale();
        }

        public double sedentaryMaintainWeightCalories()
        {

            return mwc.sedentaryMaintainWeightCalories();
        }

        public double lightlyActiveMaintainWeightCalories()
        {

            return mwc.lightlyActiveMaintainWeightCalories();
        }

        public double moderatelyActiveMaintainWeightCalories()
        {

            return mwc.moderatelyActiveMaintainWeightCalories();
        }


        public double veryActiveMaintainWeightCalories()
        {

            return mwc.veryActiveMaintainWeightCalories();
        }

        public double extraActiveMaintainWeightCalories()
        {
           return mwc.extraActiveMaintainWeightCalories();
        }


        public double lose500gr()
        {
            return mwc.lose500gr();
        }

        public double lose1000gr()
        {
            return mwc.lose1000gr();
        }

        public double add500gr()
        {
            return mwc.add500gr();
        }

        public double add1000gr()
        {
            return mwc.add1000gr();
        }

        public string loseOrGain()
        {
            return mwc.loseOrGain();
        }
    }
}
