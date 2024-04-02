using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DigimonAndTamerCharacterSheets
{
    public partial class Form1 : Form
    {
        private string xmlFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CharacterInformation.xml");

        public Form1()
        {
            InitializeComponent();
            LoadCharacterInformation(); // Load data when the form initializes
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveCharacterInformation(); // Save data when the form is closing
        }

        private void LoadCharacterInformation()
        {
            try
            {
                if (System.IO.File.Exists(xmlFilePath))
                {
                    // Load the XML document if the file exists
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(xmlFilePath);

                    // Read character data from XML
                    string playerName = xmlDoc.SelectSingleNode("/CharacterInformation/PlayerName")?.InnerText;
                    string characterName = xmlDoc.SelectSingleNode("/CharacterInformation/CharacterName")?.InnerText;
                    string characterGender = xmlDoc.SelectSingleNode("/CharacterInformation/CharacterGender")?.InnerText;

                    // Populate textboxes
                    PlayerName.Text = playerName;
                    CharacterName.Text = characterName;
                    CharacterGender.Text = characterGender;
                }
                else
                {
                    // Handle missing file scenario (e.g., display a message)
                    MessageBox.Show("Character information file not found. Creating a new one.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading character information: {ex.Message}");
            }
        }

        private void SaveCharacterInformation()
        {
            try
            {
                // Create or load the XML document
                XmlDocument xmlDoc = new XmlDocument();
                if (System.IO.File.Exists(xmlFilePath))
                    xmlDoc.Load(xmlFilePath);
                else
                    xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null));

                // Update character data
                XmlElement playerNameElement = (XmlElement)xmlDoc.SelectSingleNode("/CharacterInformation/PlayerName");
                if (playerNameElement != null)
                {
                    playerNameElement.InnerText = PlayerName.Text;
                }
                XmlElement characterNameElement = (XmlElement)xmlDoc.SelectSingleNode("/CharacterInformation/CharacterName");
                if (characterNameElement != null)
                {
                    characterNameElement.InnerText = CharacterName.Text;
                }
                XmlElement characterGenderElement = (XmlElement)xmlDoc.SelectSingleNode("/CharacterInformation/CharacterGender");
                if (characterGenderElement != null)
                {
                    characterGenderElement.InnerText = CharacterGender.Text;
                }

                // Save the XML back to the file
                xmlDoc.Save(xmlFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving character information: {ex.Message}");
            }
        }

        public void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        public void trackBar4_Scroll(object sender, EventArgs e)
        {

        }

        public void trackBar5_Scroll(object sender, EventArgs e)
        {

        }

        public void trackBar6_Scroll(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        public void trackBar3_Scroll(object sender, EventArgs e)
        {

        }

        public void trackBar12_Scroll(object sender, EventArgs e)
        {

        }

        public void trackBar11_Scroll(object sender, EventArgs e)
        {

        }

        public void trackBar10_Scroll(object sender, EventArgs e)
        {

        }

        public void trackBar15_Scroll(object sender, EventArgs e)
        {

        }

        public void trackBar14_Scroll(object sender, EventArgs e)
        {

        }

        public void trackBar13_Scroll(object sender, EventArgs e)
        {

        }

        public void trackBar9_Scroll(object sender, EventArgs e)
        {

        }

        public void trackBar8_Scroll(object sender, EventArgs e)
        {

        }

        public void trackBar7_Scroll(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void TamerSkills_Click(object sender, EventArgs e)
        {

        }

        private void Bruise_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TamerStats_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BruiseFive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InjuryTwo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InjuryThree_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InjuryFour_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InjuryFive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WoundTwo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WoundThree_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WoundFour_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WoundOne_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

            // Read input from TextBox
            string HealthNow = CurrentHealth.Text;
            string HealthMod = ModifyHealth.Text;
            string HealthMax = MaxHealth.Text;

            // Try to convert to integers
            int HealthNowValue;
            int HealthModValue;
            int HealthMaxValue;
            int.TryParse(HealthMax, out HealthMaxValue);

            if (int.TryParse(HealthNow, out HealthNowValue) && int.TryParse(HealthMod, out HealthModValue))
            {
                // Calculation
                HealthNowValue = HealthNowValue + HealthModValue;

                // Convert the calculated integer back to a string
                string updatedHealthString = HealthNowValue.ToString();

                // Update the text property
                CurrentHealth.Text = updatedHealthString;
            }
            else
            {
                // Handle the conversion failure (e.g., display an error message)
                MessageBox.Show("Please enter valid numbers for health  modification.");
            }

            if (HealthMaxValue < HealthNowValue)
            {
                CurrentHealth.Text = MaxHealth.Text;
            }


        }

        private void button21_Click(object sender, EventArgs e)
        {

            // Read input from TextBox
            string HealthNow = CurrentHealth.Text;
            string HealthMod = ModifyHealth.Text;

            // Try to convert to integers
            int HealthNowValue;
            int HealthModValue;

            if (int.TryParse(HealthNow, out HealthNowValue) && int.TryParse(HealthMod, out HealthModValue))
            {
                if (HealthNowValue == 0)
                {
                    Wound.PerformClick();
                }

                // Calculation
                HealthNowValue = HealthNowValue - HealthModValue;

                // Convert the calculated integer back to a string
                string updatedHealthString = HealthNowValue.ToString();

                // Update the text property
                CurrentHealth.Text = updatedHealthString;
            }
            else
            {
                // Handle the conversion failure (e.g., display an error message)
                MessageBox.Show("Please enter valid numbers for health  modification.");
            }

            if (HealthNowValue < 0)
            {
                CurrentHealth.Text = "0";
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }




        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void WoundTwo_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void WoundFive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WoundFour_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void InjuryOne_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            // If InjuryFive is checked
            if (InjuryFive.Checked)
            {
                // Click Injury
                Wound.PerformClick();
            }
            // If InjuryFour is checked
            else if (InjuryFour.Checked)
            {
                InjuryFive.Checked = true;
                BruiseFive.Checked = true;
            }
            // If InjuryThree is checked
            else if (InjuryThree.Checked)
            {
                InjuryFour.Checked = true;
                BruiseFour.Checked = true;
            }
            // If InjuryTwo is checked
            else if (InjuryTwo.Checked)
            {
                InjuryThree.Checked = true;
                BruiseThree.Checked = true;
            }
            // If InjuryOne is checked
            else if (InjuryOne.Checked)
            {
                InjuryTwo.Checked = true;
                BruiseTwo.Checked = true;
            }
            else
            {
                InjuryOne.Checked = true;
                BruiseOne.Checked = true;
            }

        }

        private void Bruise_Click(object sender, EventArgs e)
        {
            // If BruiseFive is checked
            if (BruiseFive.Checked)
            {
                // Click Injury
                Injury.PerformClick();
            }
            // If BruiseFour is checked
            if (BruiseFour.Checked)
            {
                BruiseFive.Checked = true;
            }
            // If BruiseThree is checked
            if (BruiseThree.Checked)
            {
                BruiseFour.Checked = true;
            }
            // If BruiseTwo is checked
            if (BruiseTwo.Checked)
            {
                BruiseThree.Checked = true;
            }
            // If BruiseOne is checked
            if (BruiseOne.Checked)
            {
                BruiseTwo.Checked = true;
            }
            else
            {
                BruiseOne.Checked = true;
            }

        }

        int SkillPoints = 1;

        // Strength Dice
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }


            // Carry Trackbar
            public void trackBar12_Scroll_1(object sender, EventArgs e)
        {

            // Calculate the total of the Strength Skills
            int totalValue = (int)CarryTrack.Value + (int)ThrowTrack.Value + (int)HoldTrack.Value;

            // Halve the totalValue and round up
            int halvedValue = (int)Math.Ceiling(totalValue / 2.0);

            // Output the halvedValue to the text box
            StrengthStat.Text = halvedValue.ToString();
        }

        // Carry Calculations
        private void button5_Click_1(object sender, EventArgs e)
        {
            // Read input from TextBox
            string userInput = StrengthStat.Text;



            // Try to convert to an integer
            if (int.TryParse(userInput, out int StrengthScore))
            {
                // Get the number of dice from the TrackBar
                int NumberOfDice = StrengthScore;

                // Apply the modifiers
                if (CarryPlusOne.Checked)
                {
                    NumberOfDice++;
                }
                if (CarryPlusTwo.Checked)
                {
                    NumberOfDice++;
                }
                if (CarryMinusOne.Checked)
                {
                    NumberOfDice--;
                }
                if (CarryMinusTwo.Checked)
                {
                    NumberOfDice--;
                }


                // Simulate rolling dice
                Random random = new Random();
                int TotalResult = 0;
                string IndividualRolls = "";
                string CoreRoll = "";


                for (int i = 0; i < NumberOfDice; i++)
                {
                    // Generates a random number between 1 and 10
                    int DiceResult = random.Next(1, 11);
                    TotalResult += DiceResult;
                    // Collect individual rolls
                    IndividualRolls += DiceResult + " ";
                }

                // Generates a random number between 1 and 20
                int D20Result = random.Next(1, 21);
                TotalResult += D20Result;
                // Collect individual rolls
                CoreRoll += D20Result + " ";

                // Final result
                TotalResult += CarryTrack.Value * 2;

                // Display the result
                MessageBox.Show($"Character Roll: {CoreRoll}\nCarry Skill: {CarryTrack.Value * 2}\nAdditional Rolls: {IndividualRolls}\nTotal Result: {TotalResult}");
            }

            else
            {
                // Invalid input (not an integer)
                MessageBox.Show("Please enter a valid integer for Strength Stat.", "Error");
            }
        }

        // Throw Trackbar
        public void trackBar11_Scroll_1(object sender, EventArgs e)
        {
            // Calculate the total of the Strength Skills
            int totalValue = (int)CarryTrack.Value + (int)ThrowTrack.Value + (int)HoldTrack.Value;

            // Halve the totalValue and round up
            int halvedValue = (int)Math.Ceiling(totalValue / 2.0);

            // Output the halvedValue to the text box
            StrengthStat.Text = halvedValue.ToString();


            // Spent Skill Points
            TrackBar[] tracks = new TrackBar[] { CarryTrack, ThrowTrack, HoldTrack, BalanceTrack, ParkourTrack, ReflexTrack, PerformTrack, IntimidateTrack, PersuadeTrack, InvestigationTrack, EmpathyTrack, IngenuityTrack, TechnologyTrack, OccultismTrack, SocietyTrack };

            foreach (TrackBar track in tracks)
            {
                track.Enabled = false;
            }
        }

        // Throw Calculations
        private void button6_Click_1(object sender, EventArgs e)
        {
            // Read input from TextBox
            string userInput = StrengthStat.Text;

            // Try to convert to an integer
            if (int.TryParse(userInput, out int StrengthScore))
            {
                // Get the number of dice from the TrackBar
                int NumberOfDice = StrengthScore;

                // Apply the modifiers
                if (ThrowPlusOne.Checked)
                {
                    NumberOfDice++;
                }
                if (ThrowPlusTwo.Checked)
                {
                    NumberOfDice++;
                }
                if (ThrowMinusOne.Checked)
                {
                    NumberOfDice--;
                }
                if (ThrowMinusTwo.Checked)
                {
                    NumberOfDice--;
                }


                // Simulate rolling dice
                Random random = new Random();
                int TotalResult = 0;
                string IndividualRolls = "";
                string CoreRoll = "";

                for (int i = 0; i < NumberOfDice; i++)
                {
                    // Generates a random number between 1 and 10
                    int DiceResult = random.Next(1, 11);
                    TotalResult += DiceResult;
                    // Collect individual rolls
                    IndividualRolls += DiceResult + " ";
                }

                // Generates a random number between 1 and 20
                int D20Result = random.Next(1, 21);
                TotalResult += D20Result;
                // Collect individual rolls
                CoreRoll += D20Result + " ";

                TotalResult += ThrowTrack.Value * 2;

                // Display the result
                MessageBox.Show($"Character Roll: {CoreRoll}\nThrow Skill: {ThrowTrack.Value * 2}\nAdditional Rolls: {IndividualRolls}\nTotal Result: {TotalResult}");
            }
            else
            {
                // Invalid input (not an integer)
                MessageBox.Show("Please enter a valid integer for Strength Stat.", "Error");
            }
        }

        // Hold Trackbar
        public void trackBar10_Scroll_1(object sender, EventArgs e)
        {
            // Calculate the total of the Strength Skills
            int totalValue = (int)CarryTrack.Value + (int)ThrowTrack.Value + (int)HoldTrack.Value;

            // Halve the totalValue and round up
            int halvedValue = (int)Math.Ceiling(totalValue / 2.0);

            // Output the halvedValue to the text box
            StrengthStat.Text = halvedValue.ToString();


            // Spent Skill Points
            TrackBar[] tracks = new TrackBar[] { CarryTrack, ThrowTrack, HoldTrack, BalanceTrack, ParkourTrack, ReflexTrack, PerformTrack, IntimidateTrack, PersuadeTrack, InvestigationTrack, EmpathyTrack, IngenuityTrack, TechnologyTrack, OccultismTrack, SocietyTrack };

            foreach (TrackBar track in tracks)
            {
                track.Enabled = false;
            }
        }

        // Hold Calculations
        private void button7_Click_1(object sender, EventArgs e)
        {
            // Read input from TextBox
            string userInput = StrengthStat.Text;

            // Try to convert to an integer
            if (int.TryParse(userInput, out int StrengthScore))
            {
                // Get the number of dice from the TrackBar
                int NumberOfDice = StrengthScore;

                // Apply the modifiers
                if (HoldPlusOne.Checked)
                {
                    NumberOfDice++;
                }
                if (HoldPlusTwo.Checked)
                {
                    NumberOfDice++;
                }
                if (HoldMinusOne.Checked)
                {
                    NumberOfDice--;
                }
                if (HoldMinusTwo.Checked)
                {
                    NumberOfDice--;
                }

                // Simulate rolling dice
                Random random = new Random();
                int TotalResult = 0;
                string IndividualRolls = "";
                string CoreRoll = "";

                for (int i = 0; i < NumberOfDice; i++)
                {
                    // Generates a random number between 1 and 10
                    int DiceResult = random.Next(1, 11);
                    TotalResult += DiceResult;
                    // Collect individual rolls
                    IndividualRolls += DiceResult + " ";
                }

                // Generates a random number between 1 and 20
                int D20Result = random.Next(1, 21);
                TotalResult += D20Result;
                // Collect individual rolls
                CoreRoll += D20Result + " ";

                TotalResult += HoldTrack.Value * 2;

                // Display the result
                MessageBox.Show($"Character Roll: {CoreRoll}\nHold Skill: {HoldTrack.Value * 2}\nAdditional Rolls: {IndividualRolls}\nTotal Result: {TotalResult}");
            }
            else
            {
                // Invalid input (not an integer)
                MessageBox.Show("Please enter a valid integer for Strength Stat.", "Error");
            }

        }

        // Agility Dice
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        // Balance Trackbar
        public void trackBar6_Scroll_1(object sender, EventArgs e)
        {
            {
                // Calculate the total of the Strength Skills
                int totalValue = (int)BalanceTrack.Value + (int)ParkourTrack.Value + (int)ReflexTrack.Value;

                // Halve the totalValue and round up
                int halvedValue = (int)Math.Ceiling(totalValue / 2.0);

                // Output the halvedValue to the text box
                AgilityStat.Text = halvedValue.ToString();


                // Spent Skill Points
                TrackBar[] tracks = new TrackBar[] { CarryTrack, ThrowTrack, HoldTrack, BalanceTrack, ParkourTrack, ReflexTrack, PerformTrack, IntimidateTrack, PersuadeTrack, InvestigationTrack, EmpathyTrack, IngenuityTrack, TechnologyTrack, OccultismTrack, SocietyTrack };

                foreach (TrackBar track in tracks)
                {
                    track.Enabled = false;
                }
            }
        }

            // Balance Calculations
            private void button10_Click_1(object sender, EventArgs e)
            {
                // Read input from TextBox
                string userInput = AgilityStat.Text;

                // Try to convert to an integer
                if (int.TryParse(userInput, out int AgilityScore))
                {
                    // Get the number of dice from the TrackBar
                    int NumberOfDice = AgilityScore;

                    // Apply the modifiers
                    if (BalancePlusOne.Checked)
                    {
                        NumberOfDice++;
                    }
                    if (BalancePlusTwo.Checked)
                    {
                        NumberOfDice++;
                    }
                    if (BalanceMinusOne.Checked)
                    {
                        NumberOfDice--;
                    }
                    if (BalanceMinusTwo.Checked)
                    {
                        NumberOfDice--;
                    }


                    // Simulate rolling dice
                    Random random = new Random();
                    int TotalResult = 0;
                    string IndividualRolls = "";
                    string CoreRoll = "";

                    for (int i = 0; i < NumberOfDice; i++)
                    {
                        // Generates a random number between 1 and 10
                        int DiceResult = random.Next(1, 11);
                        TotalResult += DiceResult;
                        // Collect individual rolls
                        IndividualRolls += DiceResult + " ";
                    }

                    // Generates a random number between 1 and 20
                    int D20Result = random.Next(1, 21);
                    TotalResult += D20Result;
                    // Collect individual rolls
                    CoreRoll += D20Result + " ";

                    TotalResult += BalanceTrack.Value * 2;

                    // Display the result
                    MessageBox.Show($"Character Roll: {CoreRoll}\nBalance Skill: {BalanceTrack.Value * 2}\nAdditional Rolls: {IndividualRolls}\nTotal Result: {TotalResult}");
                }

                else
                {
                    // Invalid input (not an integer)
                    MessageBox.Show("Please enter a valid integer for Agility Stat.", "Error");
                }
            }

        // Parkour Trackbar
        public void trackBar5_Scroll_1(object sender, EventArgs e)
            {
                {
                    // Calculate the total of the Strength Skills
                    int totalValue = (int)BalanceTrack.Value + (int)ParkourTrack.Value + (int)ReflexTrack.Value;

                    // Halve the totalValue and round up
                    int halvedValue = (int)Math.Ceiling(totalValue / 2.0);

                    // Output the halvedValue to the text box
                    AgilityStat.Text = halvedValue.ToString();


                    // Spent Skill Points
                    TrackBar[] tracks = new TrackBar[] { CarryTrack, ThrowTrack, HoldTrack, BalanceTrack, ParkourTrack, ReflexTrack, PerformTrack, IntimidateTrack, PersuadeTrack, InvestigationTrack, EmpathyTrack, IngenuityTrack, TechnologyTrack, OccultismTrack, SocietyTrack };

                    foreach (TrackBar track in tracks)
                    {
                        track.Enabled = false;
                    }
                }
            }

        // Parkour Calculations
        private void button9_Click_1(object sender, EventArgs e)
        {
            // Read input from TextBox
            string userInput = AgilityStat.Text;

            // Try to convert to an integer
            if (int.TryParse(userInput, out int AgilityScore))
            {
                // Get the number of dice from the TrackBar
                int NumberOfDice = AgilityScore;

                // Apply the modifiers
                if (ParkourPlusOne.Checked)
                {
                    NumberOfDice++;
                }
                if (ParkourPlusTwo.Checked)
                {
                    NumberOfDice++;
                }
                if (ParkourMinusTwo.Checked)
                {
                    NumberOfDice--;
                }
                if (ParkourMinusTwo.Checked)
                {
                    NumberOfDice--;
                }


                // Simulate rolling dice
                Random random = new Random();
                int TotalResult = 0;
                string IndividualRolls = "";
                string CoreRoll = "";

                for (int i = 0; i < NumberOfDice; i++)
                {
                    // Generates a random number between 1 and 10
                    int DiceResult = random.Next(1, 11);
                    TotalResult += DiceResult;
                    // Collect individual rolls
                    IndividualRolls += DiceResult + " ";
                }

                // Generates a random number between 1 and 20
                int D20Result = random.Next(1, 21);
                TotalResult += D20Result;
                // Collect individual rolls
                CoreRoll += D20Result + " ";

                TotalResult += ParkourTrack.Value * 2;

                // Display the result
                MessageBox.Show($"Character Roll: {CoreRoll}\nParkour Skill: {ParkourTrack.Value * 2}\nAdditional Rolls: {IndividualRolls}\nTotal Result: {TotalResult}");
            }
            else
            {
                // Invalid input (not an integer)
                MessageBox.Show("Please enter a valid integer for Agility Stat.", "Error");
            }
        }

        // Reflex Trackbar
        public void trackBar4_Scroll_1(object sender, EventArgs e)
        {
            {
                // Calculate the total of the Strength Skills
                int totalValue = (int)BalanceTrack.Value + (int)ParkourTrack.Value + (int)ReflexTrack.Value;

                // Halve the totalValue and round up
                int halvedValue = (int)Math.Ceiling(totalValue / 2.0);

                // Output the halvedValue to the text box
                AgilityStat.Text = halvedValue.ToString();


                // Spent Skill Points
                TrackBar[] tracks = new TrackBar[] { CarryTrack, ThrowTrack, HoldTrack, BalanceTrack, ParkourTrack, ReflexTrack, PerformTrack, IntimidateTrack, PersuadeTrack, InvestigationTrack, EmpathyTrack, IngenuityTrack, TechnologyTrack, OccultismTrack, SocietyTrack };

                foreach (TrackBar track in tracks)
                {
                    track.Enabled = false;
                }
            }

        }

        // Reflex Calculations
        private void button8_Click_1(object sender, EventArgs e)
        {
            // Read input from TextBox
            string userInput = AgilityStat.Text;

            // Try to convert to an integer
            if (int.TryParse(userInput, out int AgilityScore))
            {
                // Get the number of dice from the TrackBar
                int NumberOfDice = AgilityScore;

                // Apply the modifiers
                if (ReflexPlusOne.Checked)
                {
                    NumberOfDice++;
                }
                if (ReflexPlusTwo.Checked)
                {
                    NumberOfDice++;
                }
                if (ReflexMinusTwo.Checked)
                {
                    NumberOfDice--;
                }
                if (ReflexMinusTwo.Checked)
                {
                    NumberOfDice--;
                }


                // Simulate rolling dice
                Random random = new Random();
                int TotalResult = 0;
                string IndividualRolls = "";
                string CoreRoll = "";

                for (int i = 0; i < NumberOfDice; i++)
                {
                    // Generates a random number between 1 and 10
                    int DiceResult = random.Next(1, 11);
                    TotalResult += DiceResult;
                    // Collect individual rolls
                    IndividualRolls += DiceResult + " ";
                }

                // Generates a random number between 1 and 20
                int D20Result = random.Next(1, 21);
                TotalResult += D20Result;
                // Collect individual rolls
                CoreRoll += D20Result + " ";

                TotalResult += ReflexTrack.Value * 2;

                // Display the result
                MessageBox.Show($"Character Roll: {CoreRoll}\nReflex Skill: {ReflexTrack.Value * 2}\nAdditional Rolls: {IndividualRolls}\nTotal Result: {TotalResult}");
            }
            else
            {
                // Invalid input (not an integer)
                MessageBox.Show("Please enter a valid integer for Agility Stat.", "Error");
            }
        }


        // Vibes Dice
        private void VibesStat_TextChanged(object sender, EventArgs e)
        {

        }

        // Perform Trackbar
        public void trackBar9_Scroll_1(object sender, EventArgs e)
        {
            {
                // Calculate the total of the Strength Skills
                int totalValue = (int)PerformTrack.Value + (int)IntimidateTrack.Value + (int)PersuadeTrack.Value;

                // Halve the totalValue and round up
                int halvedValue = (int)Math.Ceiling(totalValue / 2.0);

                // Output the halvedValue to the text box
                VibesStat.Text = halvedValue.ToString();


                // Spent Skill Points
                TrackBar[] tracks = new TrackBar[] { CarryTrack, ThrowTrack, HoldTrack, BalanceTrack, ParkourTrack, ReflexTrack, PerformTrack, IntimidateTrack, PersuadeTrack, InvestigationTrack, EmpathyTrack, IngenuityTrack, TechnologyTrack, OccultismTrack, SocietyTrack };

                foreach (TrackBar track in tracks)
                {
                    track.Enabled = false;
                }
            }
        }

        // Perform Calculations
        private void button13_Click_1(object sender, EventArgs e)
        {
            // Read input from TextBox
            string userInput = VibesStat.Text;

            // Try to convert to an integer
            if (int.TryParse(userInput, out int VibesScore))
            {
                // Get the number of dice from the TrackBar
                int NumberOfDice = VibesScore;

                // Apply the modifiers
                if (PerformPlusOne.Checked)
                {
                    NumberOfDice++;
                }
                if (PerformPlusTwo.Checked)
                {
                    NumberOfDice++;
                }
                if (PerformMinusOne.Checked)
                {
                    NumberOfDice--;
                }
                if (PerformMinusTwo.Checked)
                {
                    NumberOfDice--;
                }


                // Simulate rolling dice
                Random random = new Random();
                int TotalResult = 0;
                string IndividualRolls = "";
                string CoreRoll = "";

                for (int i = 0; i < NumberOfDice; i++)
                {
                    // Generates a random number between 1 and 10
                    int DiceResult = random.Next(1, 11);
                    TotalResult += DiceResult;
                    // Collect individual rolls
                    IndividualRolls += DiceResult + " ";
                }

                // Generates a random number between 1 and 20
                int D20Result = random.Next(1, 21);
                TotalResult += D20Result;
                // Collect individual rolls
                CoreRoll += D20Result + " ";

                TotalResult += PerformTrack.Value * 2;

                // Display the result
                MessageBox.Show($"Character Roll: {CoreRoll}\nPerform Skill: {PerformTrack.Value * 2}\nAdditional Rolls: {IndividualRolls}\nTotal Result: {TotalResult}");
            }

            else
            {
                // Invalid input (not an integer)
                MessageBox.Show("Please enter a valid integer for Vibes Stat.", "Error");
            }
        }


        // Intimidate Trackbar
        public void trackBar8_Scroll_1(object sender, EventArgs e)
        {
            {
                // Calculate the total of the Strength Skills
                int totalValue = (int)PerformTrack.Value + (int)IntimidateTrack.Value + (int)PersuadeTrack.Value;

                // Halve the totalValue and round up
                int halvedValue = (int)Math.Ceiling(totalValue / 2.0);

                // Output the halvedValue to the text box
                VibesStat.Text = halvedValue.ToString();


                // Spent Skill Points
                TrackBar[] tracks = new TrackBar[] { CarryTrack, ThrowTrack, HoldTrack, BalanceTrack, ParkourTrack, ReflexTrack, PerformTrack, IntimidateTrack, PersuadeTrack, InvestigationTrack, EmpathyTrack, IngenuityTrack, TechnologyTrack, OccultismTrack, SocietyTrack };

                foreach (TrackBar track in tracks)
                {
                    track.Enabled = false;
                }
            }
        }

        // Intimidate Calculations
        private void button12_Click_1(object sender, EventArgs e)
        {
            // Read input from TextBox
            string userInput = VibesStat.Text;

            // Try to convert to an integer
            if (int.TryParse(userInput, out int VibesScore))
            {
                // Get the number of dice from the TrackBar
                int NumberOfDice = VibesScore;

                // Apply the modifiers
                if (IntimidatePlusOne.Checked)
                {
                    NumberOfDice++;
                }
                if (IntimidatePlusTwo.Checked)
                {
                    NumberOfDice++;
                }
                if (IntimidateMinusOne.Checked)
                {
                    NumberOfDice--;
                }
                if (IntimidateMinusTwo.Checked)
                {
                    NumberOfDice--;
                }


                // Simulate rolling dice
                Random random = new Random();
                int TotalResult = 0;
                string IndividualRolls = "";
                string CoreRoll = "";

                for (int i = 0; i < NumberOfDice; i++)
                {
                    // Generates a random number between 1 and 10
                    int DiceResult = random.Next(1, 11);
                    TotalResult += DiceResult;
                    // Collect individual rolls
                    IndividualRolls += DiceResult + " ";
                }

                // Generates a random number between 1 and 20
                int D20Result = random.Next(1, 21);
                TotalResult += D20Result;
                // Collect individual rolls
                CoreRoll += D20Result + " ";

                TotalResult += IntimidateTrack.Value * 2;

                // Display the result
                MessageBox.Show($"Character Roll: {CoreRoll}\nIntimidate Skill: {IntimidateTrack.Value * 2}\nAdditional Rolls: {IndividualRolls}\nTotal Result: {TotalResult}");
            }

            else
            {
                // Invalid input (not an integer)
                MessageBox.Show("Please enter a valid integer for Vibes Stat.", "Error");
            }
        }

        // Persuade Trackbar
        public void trackBar7_Scroll_1(object sender, EventArgs e)
        {
            {
                // Calculate the total of the Strength Skills
                int totalValue = (int)PerformTrack.Value + (int)IntimidateTrack.Value + (int)PersuadeTrack.Value;

                // Halve the totalValue and round up
                int halvedValue = (int)Math.Ceiling(totalValue / 2.0);

                // Output the halvedValue to the text box
                VibesStat.Text = halvedValue.ToString();


                // Spent Skill Points
                TrackBar[] tracks = new TrackBar[] { CarryTrack, ThrowTrack, HoldTrack, BalanceTrack, ParkourTrack, ReflexTrack, PerformTrack, IntimidateTrack, PersuadeTrack, InvestigationTrack, EmpathyTrack, IngenuityTrack, TechnologyTrack, OccultismTrack, SocietyTrack };

                foreach (TrackBar track in tracks)
                {
                    track.Enabled = false;
                }
            }
        }

        // Persuade Calculations
        private void button11_Click_1(object sender, EventArgs e)
        {
            // Read input from TextBox
            string userInput = VibesStat.Text;

            // Try to convert to an integer
            if (int.TryParse(userInput, out int VibesScore))
            {
                // Get the number of dice from the TrackBar
                int NumberOfDice = VibesScore;

                // Apply the modifiers
                if (PersuadePlusOne.Checked)
                {
                    NumberOfDice++;
                }
                if (PersuadePlusTwo.Checked)
                {
                    NumberOfDice++;
                }
                if (PersuadeMinusOne.Checked)
                {
                    NumberOfDice--;
                }
                if (PersuadeMinusTwo.Checked)
                {
                    NumberOfDice--;
                }


                // Simulate rolling dice
                Random random = new Random();
                int TotalResult = 0;
                string IndividualRolls = "";
                string CoreRoll = "";

                for (int i = 0; i < NumberOfDice; i++)
                {
                    // Generates a random number between 1 and 10
                    int DiceResult = random.Next(1, 11);
                    TotalResult += DiceResult;
                    // Collect individual rolls
                    IndividualRolls += DiceResult + " ";
                }

                // Generates a random number between 1 and 20
                int D20Result = random.Next(1, 21);
                TotalResult += D20Result;
                // Collect individual rolls
                CoreRoll += D20Result + " ";

                TotalResult += PersuadeTrack.Value * 2;

                // Display the result
                MessageBox.Show($"Character Roll: {CoreRoll}\nPersuade Skill: {PersuadeTrack.Value * 2}\nAdditional Rolls: {IndividualRolls}\nTotal Result: {TotalResult}");
            }

            else
            {
                // Invalid input (not an integer)
                MessageBox.Show("Please enter a valid integer for Vibes Stat.", "Error");
            }
        }

        // Wits Dice
        private void WitsStat_TextChanged(object sender, EventArgs e)
        {

        }

        // Investigation Tracker
        public void InvestigatonTrack_Scroll(object sender, EventArgs e)
        {
            {
                // Calculate the total of the Strength Skills
                int totalValue = (int)InvestigationTrack.Value + (int)EmpathyTrack.Value + (int)IngenuityTrack.Value;

                // Halve the totalValue and round up
                int halvedValue = (int)Math.Ceiling(totalValue / 2.0);

                // Output the halvedValue to the text box
                WitsStat.Text = halvedValue.ToString();


                // Spent Skill Points
                TrackBar[] tracks = new TrackBar[] { CarryTrack, ThrowTrack, HoldTrack, BalanceTrack, ParkourTrack, ReflexTrack, PerformTrack, IntimidateTrack, PersuadeTrack, InvestigationTrack, EmpathyTrack, IngenuityTrack, TechnologyTrack, OccultismTrack, SocietyTrack };

                foreach (TrackBar track in tracks)
                {
                    track.Enabled = false;
                }
            }

        }

        // Investigation Calculations
        private void button16_Click_1(object sender, EventArgs e)
        {
            // Read input from TextBox
            string userInput = WitsStat.Text;

            // Try to convert to an integer
            if (int.TryParse(userInput, out int WitsScore))
            {
                // Get the number of dice from the TrackBar
                int NumberOfDice = WitsScore;

                // Apply the modifiers
                if (InvestigationPlusOne.Checked)
                {
                    NumberOfDice++;
                }
                if (InvestigationPlusTwo.Checked)
                {
                    NumberOfDice++;
                }
                if (InvestigationMinusOne.Checked)
                {
                    NumberOfDice--;
                }
                if (InvestigationMinusTwo.Checked)
                {
                    NumberOfDice--;
                }


                // Simulate rolling dice
                Random random = new Random();
                int TotalResult = 0;
                string IndividualRolls = "";
                string CoreRoll = "";

                for (int i = 0; i < NumberOfDice; i++)
                {
                    // Generates a random number between 1 and 10
                    int DiceResult = random.Next(1, 11);
                    TotalResult += DiceResult;
                    // Collect individual rolls
                    IndividualRolls += DiceResult + " ";
                }

                // Generates a random number between 1 and 20
                int D20Result = random.Next(1, 21);
                TotalResult += D20Result;
                // Collect individual rolls
                CoreRoll += D20Result + " ";

                TotalResult += InvestigationTrack.Value * 2;

                // Display the result
                MessageBox.Show($"Character Roll: {CoreRoll}\nInvestigation Skill: {InvestigationTrack.Value * 2}\nAdditional Rolls: {IndividualRolls}\nTotal Result: {TotalResult}");
            }

            else
            {
                // Invalid input (not an integer)
                MessageBox.Show("Please enter a valid integer for Wits Stat.", "Error");
            }
        }

        // Empathy Tracker
        public void EmpathyTrack_Scroll(object sender, EventArgs e)
        {
            {
                // Calculate the total of the Strength Skills
                int totalValue = (int)InvestigationTrack.Value + (int)EmpathyTrack.Value + (int)IngenuityTrack.Value;

                // Halve the totalValue and round up
                int halvedValue = (int)Math.Ceiling(totalValue / 2.0);

                // Output the halvedValue to the text box
                WitsStat.Text = halvedValue.ToString();


                // Spent Skill Points
                TrackBar[] tracks = new TrackBar[] { CarryTrack, ThrowTrack, HoldTrack, BalanceTrack, ParkourTrack, ReflexTrack, PerformTrack, IntimidateTrack, PersuadeTrack, InvestigationTrack, EmpathyTrack, IngenuityTrack, TechnologyTrack, OccultismTrack, SocietyTrack };

                foreach (TrackBar track in tracks)
                {
                    track.Enabled = false;
                }
            }

        }

        // Empathy Calculations
        private void button15_Click_1(object sender, EventArgs e)
        {
            // Read input from TextBox
            string userInput = WitsStat.Text;

            // Try to convert to an integer
            if (int.TryParse(userInput, out int WitsScore))
            {
                // Get the number of dice from the TrackBar
                int NumberOfDice = WitsScore;

                // Apply the modifiers
                if (EmpathyPlusOne.Checked)
                {
                    NumberOfDice++;
                }
                if (EmpathyPlusTwo.Checked)
                {
                    NumberOfDice++;
                }
                if (EmpathyMinusOne.Checked)
                {
                    NumberOfDice--;
                }
                if (EmpathyMinusTwo.Checked)
                {
                    NumberOfDice--;
                }


                // Simulate rolling dice
                Random random = new Random();
                int TotalResult = 0;
                string IndividualRolls = "";
                string CoreRoll = "";

                for (int i = 0; i < NumberOfDice; i++)
                {
                    // Generates a random number between 1 and 10
                    int DiceResult = random.Next(1, 11);
                    TotalResult += DiceResult;
                    // Collect individual rolls
                    IndividualRolls += DiceResult + " ";
                }

                // Generates a random number between 1 and 20
                int D20Result = random.Next(1, 21);
                TotalResult += D20Result;
                // Collect individual rolls
                CoreRoll += D20Result + " ";

                TotalResult += EmpathyTrack.Value * 2;

                // Display the result
                MessageBox.Show($"Character Roll: {CoreRoll}\nEmpathy Skill: {EmpathyTrack.Value * 2}\nAdditional Rolls: {IndividualRolls}\nTotal Result: {TotalResult}");
            }

            else
            {
                // Invalid input (not an integer)
                MessageBox.Show("Please enter a valid integer for Wits Stat.", "Error");
            }
        }

        // Ingenuity Tracker
        public void IngenuityTrack_Scroll(object sender, EventArgs e)
        {
            {
                // Calculate the total of the Strength Skills
                int totalValue = (int)InvestigationTrack.Value + (int)EmpathyTrack.Value + (int)IngenuityTrack.Value;

                // Halve the totalValue and round up
                int halvedValue = (int)Math.Ceiling(totalValue / 2.0);

                // Output the halvedValue to the text box
                WitsStat.Text = halvedValue.ToString();


                // Spent Skill Points
                TrackBar[] tracks = new TrackBar[] { CarryTrack, ThrowTrack, HoldTrack, BalanceTrack, ParkourTrack, ReflexTrack, PerformTrack, IntimidateTrack, PersuadeTrack, InvestigationTrack, EmpathyTrack, IngenuityTrack, TechnologyTrack, OccultismTrack, SocietyTrack };

                foreach (TrackBar track in tracks)
                {
                    track.Enabled = false;
                }
            }

        }

        // Ingenuity Calculations
        private void button14_Click_1(object sender, EventArgs e)
        {
            // Read input from TextBox
            string userInput = WitsStat.Text;

            // Try to convert to an integer
            if (int.TryParse(userInput, out int WitsScore))
            {
                // Get the number of dice from the TrackBar
                int NumberOfDice = WitsScore;

                // Apply the modifiers
                if (IngenuityPlusOne.Checked)
                {
                    NumberOfDice++;
                }
                if (IngenuityPlusTwo.Checked)
                {
                    NumberOfDice++;
                }
                if (IngenuityMinusTwo.Checked)
                {
                    NumberOfDice--;
                }
                if (IngenuityMinusTwo.Checked)
                {
                    NumberOfDice--;
                }


                // Simulate rolling dice
                Random random = new Random();
                int TotalResult = 0;
                string IndividualRolls = "";
                string CoreRoll = "";

                for (int i = 0; i < NumberOfDice; i++)
                {
                    // Generates a random number between 1 and 10
                    int DiceResult = random.Next(1, 11);
                    TotalResult += DiceResult;
                    // Collect individual rolls
                    IndividualRolls += DiceResult + " ";
                }

                // Generates a random number between 1 and 20
                int D20Result = random.Next(1, 21);
                TotalResult += D20Result;
                // Collect individual rolls
                CoreRoll += D20Result + " ";

                TotalResult += IngenuityTrack.Value * 2;

                // Display the result
                MessageBox.Show($"Character Roll: {CoreRoll}\nWits Skill: {IngenuityTrack.Value * 2}\nAdditional Rolls: {IndividualRolls}\nTotal Result: {TotalResult}");
            }

            else
            {
                // Invalid input (not an integer)
                MessageBox.Show("Please enter a valid integer for Wits Stat.", "Error");
            }
        }

        // Knowledge Dice
        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        // Technology Tracker
        public void TechnologyTrack_Scroll(object sender, EventArgs e)
        {
            {
                // Calculate the total of the Strength Skills
                int totalValue = (int)TechnologyTrack.Value + (int)OccultismTrack.Value + (int)SocietyTrack.Value;

                // Halve the totalValue and round up
                int halvedValue = (int)Math.Ceiling(totalValue / 2.0);

                // Output the halvedValue to the text box
                KnowledgeStat.Text = halvedValue.ToString();


                // Spent Skill Points
                TrackBar[] tracks = new TrackBar[] { CarryTrack, ThrowTrack, HoldTrack, BalanceTrack, ParkourTrack, ReflexTrack, PerformTrack, IntimidateTrack, PersuadeTrack, InvestigationTrack, EmpathyTrack, IngenuityTrack, TechnologyTrack, OccultismTrack, SocietyTrack };

                foreach (TrackBar track in tracks)
                {
                    track.Enabled = false;
                }
            }
        }

        // Technology Calculatons
        private void button19_Click_1(object sender, EventArgs e)
        {
            // Read input from TextBox
            string userInput = KnowledgeStat.Text;

            // Try to convert to an integer
            if (int.TryParse(userInput, out int KnowledgeScore))
            {
                // Get the number of dice from the TrackBar
                int NumberOfDice = KnowledgeScore;

                // Apply the modifiers
                if (TechnologyPlusOne.Checked)
                {
                    NumberOfDice++;
                }
                if (TechnologyPlusTwo.Checked)
                {
                    NumberOfDice++;
                }
                if (TechnologyMinusTwo.Checked)
                {
                    NumberOfDice--;
                }
                if (TechnologyMinusTwo.Checked)
                {
                    NumberOfDice--;
                }


                // Simulate rolling dice
                Random random = new Random();
                int TotalResult = 0;
                string IndividualRolls = "";
                string CoreRoll = "";

                for (int i = 0; i < NumberOfDice; i++)
                {
                    // Generates a random number between 1 and 10
                    int DiceResult = random.Next(1, 11);
                    TotalResult += DiceResult;
                    // Collect individual rolls
                    IndividualRolls += DiceResult + " ";
                }

                // Generates a random number between 1 and 20
                int D20Result = random.Next(1, 21);
                TotalResult += D20Result;
                // Collect individual rolls
                CoreRoll += D20Result + " ";

                TotalResult += TechnologyTrack.Value * 2;

                // Display the result
                MessageBox.Show($"Character Roll: {CoreRoll}\nTechnology Skill: {TechnologyTrack.Value * 2}\nAdditional Rolls: {IndividualRolls}\nTotal Result: {TotalResult}");
            }

            else
            {
                // Invalid input (not an integer)
                MessageBox.Show("Please enter a valid integer for Knowledge Stat.", "Error");
            }
        }

        // Occultism Tracker
        public void OccultismTrack_Scroll(object sender, EventArgs e)
        {
            {
                // Calculate the total of the Strength Skills
                int totalValue = (int)TechnologyTrack.Value + (int)OccultismTrack.Value + (int)SocietyTrack.Value;

                // Halve the totalValue and round up
                int halvedValue = (int)Math.Ceiling(totalValue / 2.0);

                // Output the halvedValue to the text box
                KnowledgeStat.Text = halvedValue.ToString();


                // Spent Skill Points
                TrackBar[] tracks = new TrackBar[] { CarryTrack, ThrowTrack, HoldTrack, BalanceTrack, ParkourTrack, ReflexTrack, PerformTrack, IntimidateTrack, PersuadeTrack, InvestigationTrack, EmpathyTrack, IngenuityTrack, TechnologyTrack, OccultismTrack, SocietyTrack };

                foreach (TrackBar track in tracks)
                {
                    track.Enabled = false;
                }
            }
        }

        // Occultism Calculatons
        private void button18_Click_1(object sender, EventArgs e)
        {
            // Read input from TextBox
            string userInput = KnowledgeStat.Text;

            // Try to convert to an integer
            if (int.TryParse(userInput, out int KnowledgeScore))
            {
                // Get the number of dice from the TrackBar
                int NumberOfDice = KnowledgeScore;

                // Apply the modifiers
                if (OccultismPlusOne.Checked)
                {
                    NumberOfDice++;
                }
                if (OccultismPlusTwo.Checked)
                {
                    NumberOfDice++;
                }
                if (OccultismMinusTwo.Checked)
                {
                    NumberOfDice--;
                }
                if (OccultismMinusTwo.Checked)
                {
                    NumberOfDice--;
                }


                // Simulate rolling dice
                Random random = new Random();
                int TotalResult = 0;
                string IndividualRolls = "";
                string CoreRoll = "";

                for (int i = 0; i < NumberOfDice; i++)
                {
                    // Generates a random number between 1 and 10
                    int DiceResult = random.Next(1, 11);
                    TotalResult += DiceResult;
                    // Collect individual rolls
                    IndividualRolls += DiceResult + " ";
                }

                // Generates a random number between 1 and 20
                int D20Result = random.Next(1, 21);
                TotalResult += D20Result;
                // Collect individual rolls
                CoreRoll += D20Result + " ";

                TotalResult += OccultismTrack.Value * 2;

                // Display the result
                MessageBox.Show($"Character Roll: {CoreRoll}\nOccultism Skill: {OccultismTrack.Value * 2}\nAdditional Rolls: {IndividualRolls}\nTotal Result: {TotalResult}");
            }

            else
            {
                // Invalid input (not an integer)
                MessageBox.Show("Please enter a valid integer for Knowledge Stat.", "Error");
            }
        }

        // Society Tracker
        public void SocietyTrack_Scroll(object sender, EventArgs e)
        {
            {
                // Calculate the total of the Strength Skills
                int totalValue = (int)TechnologyTrack.Value + (int)OccultismTrack.Value + (int)SocietyTrack.Value;

                // Halve the totalValue and round up
                int halvedValue = (int)Math.Ceiling(totalValue / 2.0);

                // Output the halvedValue to the text box
                KnowledgeStat.Text = halvedValue.ToString();


                // Spent Skill Points
                TrackBar[] tracks = new TrackBar[] { CarryTrack, ThrowTrack, HoldTrack, BalanceTrack, ParkourTrack, ReflexTrack, PerformTrack, IntimidateTrack, PersuadeTrack, InvestigationTrack, EmpathyTrack, IngenuityTrack, TechnologyTrack, OccultismTrack, SocietyTrack };

                foreach (TrackBar track in tracks)
                {
                    track.Enabled = false;
                }
            }
        }

        // Society Calculations
        private void button17_Click_1(object sender, EventArgs e)
        {
            // Read input from TextBox
            string userInput = KnowledgeStat.Text;

            // Try to convert to an integer
            if (int.TryParse(userInput, out int KnowledgeScore))
            {
                // Get the number of dice from the TrackBar
                int NumberOfDice = KnowledgeScore;

                // Apply the modifiers
                if (SocietyPlusOne.Checked)
                {
                    NumberOfDice++;
                }
                if (SocietyPlusTwo.Checked)
                {
                    NumberOfDice++;
                }
                if (SocietyMinusTwo.Checked)
                {
                    NumberOfDice--;
                }
                if (SocietyMinusTwo.Checked)
                {
                    NumberOfDice--;
                }


                // Simulate rolling dice
                Random random = new Random();
                int TotalResult = 0;
                string IndividualRolls = "";
                string CoreRoll = "";

                for (int i = 0; i < NumberOfDice; i++)
                {
                    // Generates a random number between 1 and 10
                    int DiceResult = random.Next(1, 11);
                    TotalResult += DiceResult;
                    // Collect individual rolls
                    IndividualRolls += DiceResult + " ";
                }

                // Generates a random number between 1 and 20
                int D20Result = random.Next(1, 21);
                TotalResult += D20Result;
                // Collect individual rolls
                CoreRoll += D20Result + " ";

                TotalResult += SocietyTrack.Value * 2;

                // Display the result
                MessageBox.Show($"Character Roll: {CoreRoll}\nSociety Skill: {SocietyTrack.Value * 2}\nAdditional Rolls: {IndividualRolls}\nTotal Result: {TotalResult}");
            }

            else
            {
                // Invalid input (not an integer)
                MessageBox.Show("Please enter a valid integer for Knowledge Stat.", "Error");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void trackBar16_Scroll(object sender, EventArgs e)
        {
            // Calculate the total of the Strength Skills
            int totalValue = (int)ErrorScanTrack.Value + (int)InfoExtractTrack.Value + (int)GigaSearchTrack.Value + (int)WaybackTrackTrack.Value;

            // Halve the totalValue and round up
            int halvedValue = (int)Math.Ceiling(totalValue / 2.0);

            // Output the halvedValue to the text box
            DigiSoulStat.Text = halvedValue.ToString();
        }

        private void button22_Click_1(object sender, EventArgs e)
        {

        }

        public void trackBar19_Scroll(object sender, EventArgs e)
        {
            // Calculate the total of the Strength Skills
            int totalValue = (int)ErrorScanTrack.Value + (int)InfoExtractTrack.Value + (int)GigaSearchTrack.Value + (int)WaybackTrackTrack.Value;

            // Halve the totalValue and round up
            int halvedValue = (int)Math.Ceiling(totalValue / 2.0);

            // Output the halvedValue to the text box
            DigiSoulStat.Text = halvedValue.ToString();
        }

        private void GigaSearch_Click(object sender, EventArgs e)
        {

        }

        private void InfoExtract_Click(object sender, EventArgs e)
        {

        }

        private void ErrorScan_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click_2(object sender, EventArgs e)
        {

        }

        private void TamerPowers_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click_3(object sender, EventArgs e)
        {
            int digiSoulScore;
            if (int.TryParse(DigiSoulStat.Text, out digiSoulScore) && digiSoulScore > 0)
            {
                digiSoulScore -= 1; // Subtract 1 from the score
                DigiSoulStat.Text = digiSoulScore.ToString();
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            int digiSoulScore;
            if (int.TryParse(DigiSoulStat.Text, out digiSoulScore) && digiSoulScore > 0)
            {
                digiSoulScore -= 1; // Subtract 1 from the score
                DigiSoulStat.Text = digiSoulScore.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            PlayerName.AccessibleDefaultActionDescription = PlayerName.Text;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void DigimonMoves_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void DigimonStats_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label55_Click(object sender, EventArgs e)
        {

        }

        private void label69_Click(object sender, EventArgs e)
        {

        }

        private void label75_Click(object sender, EventArgs e)
        {

        }

        private void label77_Click(object sender, EventArgs e)
        {

        }

        private void label79_Click(object sender, EventArgs e)
        {

        }

        private void label78_Click(object sender, EventArgs e)
        {

        }

        private void label76_Click(object sender, EventArgs e)
        {

        }

        private void label69_Click_1(object sender, EventArgs e)
        {

        }

        private void label82_Click(object sender, EventArgs e)
        {

        }

        private void label85_Click(object sender, EventArgs e)
        {

        }

        private void label88_Click(object sender, EventArgs e)
        {

        }

        private void label86_Click(object sender, EventArgs e)
        {

        }

        private void label83_Click(object sender, EventArgs e)
        {

        }

        private void label80_Click(object sender, EventArgs e)
        {

        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void label65_Click(object sender, EventArgs e)
        {

        }

        private void label68_Click(object sender, EventArgs e)
        {

        }

        private void label71_Click(object sender, EventArgs e)
        {

        }

        private void label67_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label110_Click(object sender, EventArgs e)
        {

        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox13_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox15_Enter(object sender, EventArgs e)
        {

        }

        private void label96_Click(object sender, EventArgs e)
        {

        }

        private void label97_Click(object sender, EventArgs e)
        {

        }

        private void label98_Click(object sender, EventArgs e)
        {

        }

        private void label99_Click(object sender, EventArgs e)
        {

        }

        private void groupBox17_Enter(object sender, EventArgs e)
        {

        }

        private void label106_Click(object sender, EventArgs e)
        {

        }

        private void label100_Click(object sender, EventArgs e)
        {

        }

        private void label102_Click(object sender, EventArgs e)
        {

        }

        private void label98_Click_1(object sender, EventArgs e)
        {

        }

        private void label106_Click_1(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void DigimonLifecycle_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label112_Click(object sender, EventArgs e)
        {

        }

        private void label116_Click(object sender, EventArgs e)
        {

        }

        private void label115_Click(object sender, EventArgs e)
        {

        }

        private void label127_Click(object sender, EventArgs e)
        {

        }

        private void label126_Click(object sender, EventArgs e)
        {

        }

        private void label124_Click(object sender, EventArgs e)
        {

        }

        private void label125_Click(object sender, EventArgs e)
        {

        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox13_Enter_1(object sender, EventArgs e)
        {

        }

        private void label133_Click(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void radioButton15_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton16_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged_3(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label134_Click(object sender, EventArgs e)
        {

        }

        private void label135_Click(object sender, EventArgs e)
        {

        }

        private void label137_Click(object sender, EventArgs e)
        {

        }

        private void label136_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_2(object sender, EventArgs e)
        {

        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BruiseOne_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label170_Click(object sender, EventArgs e)
        {

        }

        private void Wound_Click(object sender, EventArgs e)
        {
            // If WoundFive is checked
            if (WoundFive.Checked)
            {
                // Click Wound
                MessageBox.Show($"You thought you were hot...\nGuess what? You're not!\nYou are dead...\ndead... dead...");
            }
            // If WoundFour is checked
            else if (WoundFour.Checked)
            {
                WoundFive.Checked = true;
                InjuryFive.Checked = true;
                BruiseFive.Checked = true;
            }
            // If WoundThree is checked
            else if (WoundThree.Checked)
            {
                WoundFour.Checked = true;
                InjuryFour.Checked = true;
                BruiseFour.Checked = true;
            }
            // If WoundTwo is checked
            else if (WoundTwo.Checked)
            {
                WoundThree.Checked = true;
                InjuryThree.Checked = true;
                BruiseThree.Checked = true;
            }
            // If InjuryOne is checked
            else if (WoundOne.Checked)
            {
                WoundTwo.Checked = true;
                InjuryTwo.Checked = true;
                BruiseTwo.Checked = true;
            }
            else
            {
                WoundOne.Checked = true;
                InjuryOne.Checked = true;
                BruiseOne.Checked = true;
            }

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void BruiseTwo_CheckedChanged(object sender, EventArgs e)
        {
            BruiseOne.Checked = true;
        }

        private void BruiseThree_CheckedChanged(object sender, EventArgs e)
        {
            BruiseTwo.Checked = true;
        }

        private void BruiseFour_CheckedChanged(object sender, EventArgs e)
        {
            BruiseThree.Checked = true;
        }

        private void BruiseFive_CheckedChanged_1(object sender, EventArgs e)
        {
            BruiseFour.Checked = true;
        }


        private void InjuryOne_CheckedChanged_1(object sender, EventArgs e)
        {
            BruiseOne.Checked = true;
        }

        private void InjuryTwo_CheckedChanged_1(object sender, EventArgs e)
        {
            BruiseTwo.Checked = true;
            InjuryOne.Checked = true;
        }

        private void InjuryThree_CheckedChanged_1(object sender, EventArgs e)
        {
            BruiseThree.Checked = true;
            InjuryTwo.Checked = true;
        }

        private void InjuryFour_CheckedChanged_1(object sender, EventArgs e)
        {
            BruiseFour.Checked = true;
            InjuryThree.Checked = true;
        }

        private void InjuryFive_CheckedChanged_1(object sender, EventArgs e)
        {
            BruiseFive.Checked = true;
            InjuryFour.Checked = true;
        }

        private void WoundOne_CheckedChanged_1(object sender, EventArgs e)
        {
            BruiseOne.Checked = true;
            InjuryOne.Checked = true;
        }

        private void WoundTwo_CheckedChanged_2(object sender, EventArgs e)
        {
            BruiseTwo.Checked = true;
            InjuryTwo.Checked = true;
            WoundOne.Checked = true;
        }

        private void WoundThree_CheckedChanged_1(object sender, EventArgs e)
        {
            BruiseThree.Checked = true;
            InjuryThree.Checked = true;
            WoundTwo.Checked = true;
        }

        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {
            BruiseFour.Checked = true;
            InjuryFour.Checked = true;
            WoundThree.Checked = true;
        }

        private void WoundFive_CheckedChanged_1(object sender, EventArgs e)
        {
            BruiseFive.Checked = true;
            InjuryFive.Checked = true;
            WoundFour.Checked = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void trackBar18_Scroll(object sender, EventArgs e)
        {
            // Calculate the total of the Strength Skills
            int totalValue = (int)ErrorScanTrack.Value + (int)InfoExtractTrack.Value + (int)GigaSearchTrack.Value + (int)WaybackTrackTrack.Value;

            // Halve the totalValue and round up
            int halvedValue = (int)Math.Ceiling(totalValue / 2.0);

            // Output the halvedValue to the text box
            DigiSoulStat.Text = halvedValue.ToString();
        }

        public void InfoExtractTrack_Scroll(object sender, EventArgs e)
        {
            // Calculate the total of the Strength Skills
            int totalValue = (int)ErrorScanTrack.Value + (int)InfoExtractTrack.Value + (int)GigaSearchTrack.Value + (int)WaybackTrackTrack.Value;

            // Halve the totalValue and round up
            int halvedValue = (int)Math.Ceiling(totalValue / 2.0);

            // Output the halvedValue to the text box
            DigiSoulStat.Text = halvedValue.ToString();
        }

        private void ActivateHD_Click(object sender, EventArgs e)
        {
            int digiSoulScore;
            if (int.TryParse(DigiSoulStat.Text, out digiSoulScore) && digiSoulScore > 0)
            {
                digiSoulScore -= 1; // Subtract 1 from the score
                DigiSoulStat.Text = digiSoulScore.ToString();
            }
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            int digiSoulScore;
            if (int.TryParse(DigiSoulStat.Text, out digiSoulScore) && digiSoulScore > 0)
            {
                digiSoulScore -= 1; // Subtract 1 from the score
                DigiSoulStat.Text = digiSoulScore.ToString();
            }
        }

        // Level Up System
        int TamerLevel = 1;
        // Press The Butoon
        private void button22_Click_4(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Create a new instance of Form2
            form2.Show(); // Display Form2

            TamerLevel = TamerLevel + 1;
            CharacterLevel.Text = TamerLevel.ToString();
            int IncreaseHealth;
            int.TryParse(MaxHealth.Text, out IncreaseHealth);
            IncreaseHealth = 25 + ((TamerLevel - 1) * 5);
            MaxHealth.Text = IncreaseHealth.ToString();
            CurrentHealth.Text = MaxHealth.Text;

            // Level Up Boon
            TrackBar[] tracks = new TrackBar[] { CarryTrack, ThrowTrack, HoldTrack, BalanceTrack, ParkourTrack, ReflexTrack, PerformTrack, IntimidateTrack, PersuadeTrack, InvestigationTrack, EmpathyTrack, IngenuityTrack, TechnologyTrack, OccultismTrack, SocietyTrack };

            foreach (TrackBar track in tracks)
            {
                track.Enabled = true;
            }

        }
        
        private void CharacterLevel_Click(object sender, EventArgs e)
        {

        }

        private void CurrentHealth_Click(object sender, EventArgs e)
        {

        }
    }
}