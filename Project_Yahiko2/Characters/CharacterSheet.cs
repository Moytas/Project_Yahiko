using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Yahiko
{
    public partial class CharacterSheet : Form
    {
        public CharacterSheet(int playerClass)
        {
            switch(playerClass)
            {
                case 1:
                    Bushi Warrior = new Bushi();
                    lbl_ValueAge.Text = Warrior.Age.ToString();
                    lbl_ValueClass.Text = "Bushi";
                    lbl_ValueFirstName.Text = Warrior.FirstName;
                    lbl_ValueGender.Text = Warrior.Gender ? "Otoko" : "Onna";
                    lbl_ValueHeight.Text = Warrior.Height.ToString();
                    lbl_ValueHonor.Text = Warrior.Honor.ToString();
                    lbl_ValueLastName.Text = Warrior.LastName;
                    lbl_ValueLevel.Text = Warrior.Level.ToString();
                    switch(Warrior.CharacterRace)
                    {
                        case 1:
                            lbl_ValueRace.Text = "Human";
                            break;
                        case 2:
                            lbl_ValueRace.Text = "Elf";
                            break;
                        case 3:
                            lbl_ValueRace.Text = "Dwarf";
                            break;
                        case 4:
                            lbl_ValueRace.Text = "Gnome";
                            break;
                        case 5:
                            lbl_ValueRace.Text = "Halfling";
                            break;
                        case 6:
                            lbl_ValueRace.Text = "Half-Elf";
                            break;
                    }
                    lbl_ValueXPCur.Text = Warrior.XPToNext.ToString();
                    lbl_XPCur.Text = Warrior.XP.ToString();
                   
                    break;
                case 2:
                    Shinobi Thief = new Shinobi();
                    lbl_ValueAge.Text = Thief.Age.ToString();
                    lbl_ValueClass.Text = "Shinobi";
                    lbl_ValueFirstName.Text = Thief.FirstName;
                    lbl_ValueGender.Text = Thief.Gender ? "Otoko" : "Onna";
                    lbl_ValueHeight.Text = Thief.Height.ToString();
                    lbl_ValueHonor.Text = Thief.Honor.ToString();
                    lbl_ValueLastName.Text = Thief.LastName;
                    lbl_ValueLevel.Text = Thief.Level.ToString();
                    switch (Thief.CharacterRace)
                    {
                        case 1:
                            lbl_ValueRace.Text = "Human";
                            break;
                        case 2:
                            lbl_ValueRace.Text = "Elf";
                            break;
                        case 3:
                            lbl_ValueRace.Text = "Dwarf";
                            break;
                        case 4:
                            lbl_ValueRace.Text = "Gnome";
                            break;
                        case 5:
                            lbl_ValueRace.Text = "Halfling";
                            break;
                        case 6:
                            lbl_ValueRace.Text = "Half-Elf";
                            break;
                    }
                    lbl_ValueXPCur.Text = Thief.XPToNext.ToString();
                    lbl_XPCur.Text = Thief.XP.ToString();
                    break;
                case 3:
                    Sohei Priest = new Sohei();

                    lbl_ValueAge.Text = Priest.Age.ToString();
                    lbl_ValueClass.Text = "Sohei";
                    lbl_ValueFirstName.Text = Priest.FirstName;
                    lbl_ValueGender.Text = Priest.Gender ? "Otoko" : "Onna";
                    lbl_ValueHeight.Text = Priest.Height.ToString();
                    lbl_ValueHonor.Text = Priest.Honor.ToString();
                    lbl_ValueLastName.Text = Priest.LastName;
                    lbl_ValueLevel.Text = Priest.Level.ToString();
                    switch (Priest.CharacterRace)
                    {
                        case 1:
                            lbl_ValueRace.Text = "Human";
                            break;
                        case 2:
                            lbl_ValueRace.Text = "Elf";
                            break;
                        case 3:
                            lbl_ValueRace.Text = "Dwarf";
                            break;
                        case 4:
                            lbl_ValueRace.Text = "Gnome";
                            break;
                        case 5:
                            lbl_ValueRace.Text = "Halfling";
                            break;
                        case 6:
                            lbl_ValueRace.Text = "Half-Elf";
                            break;
                    }
                    lbl_ValueXPCur.Text = Priest.XPToNext.ToString();
                    lbl_XPCur.Text = Priest.XP.ToString();
                    break;
                case 4:
                    Onmyoji Mage = new Onmyoji();

                    lbl_ValueAge.Text = Mage.Age.ToString();
                    lbl_ValueClass.Text = "Onmyoji";
                    lbl_ValueFirstName.Text = Mage.FirstName;
                    lbl_ValueGender.Text = Mage.Gender ? "Otoko" : "Onna";
                    lbl_ValueHeight.Text = Mage.Height.ToString();
                    lbl_ValueHonor.Text = Mage.Honor.ToString();
                    lbl_ValueLastName.Text = Mage.LastName;
                    lbl_ValueLevel.Text = Mage.Level.ToString();
                    switch (Mage.CharacterRace)
                    {
                        case 1:
                            lbl_ValueRace.Text = "Human";
                            break;
                        case 2:
                            lbl_ValueRace.Text = "Elf";
                            break;
                        case 3:
                            lbl_ValueRace.Text = "Dwarf";
                            break;
                        case 4:
                            lbl_ValueRace.Text = "Gnome";
                            break;
                        case 5:
                            lbl_ValueRace.Text = "Halfling";
                            break;
                        case 6:
                            lbl_ValueRace.Text = "Half-Elf";
                            break;
                    }
                    lbl_ValueXPCur.Text = Mage.XPToNext.ToString();
                    lbl_XPCur.Text = Mage.XP.ToString();
                    break;
            }

            InitializeComponent();
        }
    }
}
