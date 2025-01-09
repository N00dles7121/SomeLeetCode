using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode
{
    // At a lemonade stand, each lemonade costs $5.
    // Customers are standing in a queue to buy from you and order one at a time
    // (in the order specified by bills). Each customer will only buy one lemonade
    // and pay with either a $5, $10, or $20 bill. You must provide the correct change
    // to each customer so that the net transaction is that the customer pays $5.

    public static class LemonadeChange
    {
        public static bool Solution(int[] bills)
        {

            // Initialize variables to count bills in cash
            int five = 0;
            int ten = 0;
            int twenty = 0;

            foreach (var bill in bills)
            {

                // $5 bills do not require change
                if (bill == 5)
                {
                    five++;
                    continue;
                }

                // Give $5 change if we have proper bills in cash return false if we don't
                else if (bill == 10)
                {
                    if (five > 0)
                    {
                        five--;
                        ten++;
                        continue;
                    }
                    return false;
                }

                // $20 bill case
                else
                {

                    // Give change in $5 and $10 bills if we have them in cash
                    if (five > 0 && ten > 0)
                    {
                        five--;
                        ten--;
                        twenty++;
                        continue;
                    }

                    // Check if have smaller bills to give change
                    else if (five >= 3)
                    {
                        five -= 3;
                        twenty++;
                        continue;
                    }

                    // If none return false
                    return false;
                }
            }

            // Return true if loop is done
            return true;
        }
    }
}