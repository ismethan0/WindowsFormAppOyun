using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsOyunu
{
    public  class PlayerStat
    {
       
        private  int playerSpeed = 8;
        private int playerHeahlt = 100;
        private int playerAttacSpeed = 8;
        private int playerAttackDamage = 10;
        private int playerSkor = 0;
        public int PlayerSpeed { get {  return playerSpeed; } set { playerSpeed = value; } }
        public int PlayerHeahlt { get {  return playerHeahlt; } set { playerHeahlt = value; } }
        public int PlayerAttacSpeed { get { return playerAttacSpeed; } set { playerAttacSpeed = value; } }
        public int PlayerAttackDamage { get { return playerAttackDamage; } set { playerAttackDamage = value; } }
        public int PlayerSkor { get { return playerSkor; } set { playerSkor = value; } }
        
        



    }
}
