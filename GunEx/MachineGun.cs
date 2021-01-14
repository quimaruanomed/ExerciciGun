using System;


namespace GunEx
{
 public class MachineGun : IArma
    {
     
        public MachineGun()
        {
            
        }
        public void Shoot(string target)
        {
            Console.WriteLine(target);
        }
    }

    

}

