/*Andrew Foster
* CPT-206-A01S
* Lab_4
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace andrew_foster_cpt_206_lab_2
{

    public class StateData
    {
        public static int selection;

        public string StateUpdate (int selection)
        {
            string change = "";
            if (selection == 0) { change = "name"; }
            if (selection == 1) { change = "flag"; }
            if (selection == 2) { change = "flower"; }
            if (selection == 3) { change = "bird"; }
            if (selection == 4) { change = "colors"; }
            if (selection == 5) { change = "pop"; }
            if (selection == 6) { change = "first_city"; }
            if (selection == 7) { change = "second_city"; }
            if (selection == 8) { change = "third_city"; }
            if (selection == 9) { change = "capitol"; }
            if (selection == 10) { change = "income"; }
            if (selection == 11) { change = "jobs"; }
            return change;
        }
    }
}
