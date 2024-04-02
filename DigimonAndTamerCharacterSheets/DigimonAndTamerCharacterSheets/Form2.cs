using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigimonAndTamerCharacterSheets
{

    public partial class Form2 : Form
    {

        private Form1 mainForm;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LevelButton_Click(object sender, EventArgs e)
        {
            {
                string SuperSkillSelection = (string)SuperSkillGain.SelectedItem; // Get selected Super Skill
                string BasicSkillSelection = (string)BasicSkillGain.SelectedItem; // Get selected Basic Skill

                if (BasicSkillSelection == "Carry")
                {
                    // Carry
                    mainForm.CarryTrack.Value = mainForm.CarryTrack.Value + 1;
                }
                else if (BasicSkillSelection == "Throw")
                {
                    // Throw
                }
                else if (BasicSkillSelection == "Hold")
                {
                    // Hold
                }
                else if (BasicSkillSelection == "Balance")
                {
                    // Balance
                }
                else if (BasicSkillSelection == "Parkour")
                {
                    // Parkour
                }
                else if (BasicSkillSelection == "Reflex")
                {
                    // Reflex
                }
                else if (BasicSkillSelection == "Perform")
                {
                    // Perform
                }
                else if (BasicSkillSelection == "Intimidate")
                {
                    // Intimidate
                }
                else if (BasicSkillSelection == "Persaude")
                {
                    // Persaude
                }
                else if (BasicSkillSelection == "Investigation")
                {
                    // Investigation
                }
                else if (BasicSkillSelection == "Empathy")
                {
                    // Empathy
                }
                else if (BasicSkillSelection == "Ingenuity")
                {
                    // Ingenuity
                }
                else if (BasicSkillSelection == "Technology")
                {
                    // Technology
                }
                else if (BasicSkillSelection == "Occultism")
                {
                    // Occultism
                }
                else if (BasicSkillSelection == "Society")
                {
                    // Society
                }
                else
                {
                    // Perform default action if no specific combination matches
                    MessageBox.Show("You did not select a Basic Skill.");
                }

                if (SuperSkillSelection == "Error Scan")
                {
                    // Error Scan
                }
                else if (SuperSkillSelection == "Info Extract")
                {
                    // Info Extract
                }
                else if (SuperSkillSelection == "Giga Search")
                {
                    // Giga Search
                }
                else if (SuperSkillSelection == "Wayback Track")
                {
                    // Wayback Track
                }
                else
                {
                    // Perform default action if no specific combination matches
                    MessageBox.Show("You did not select a Super Skill.");
                }

            }

        }
    }
}

