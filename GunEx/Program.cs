using System;


namespace GunEx
{
    class Program
    {
        static void Main(string[] args)
        {
               
            var machineGun = new MachineGun();
            Soldier sol1 = new Soldier( machineGun); // Injectamos Machine Gun como Dependencia 
            sol1.Shoot("Disparar Objetivo con Ametralladora " );
            //Para que el soldado pueda disparar con dos armas creamos otra arma 
           
            var machineGunSemiautomatic = new MachineGun(); //Creamos dos armas nuevas 
            var machineGunAut = new MachineGun();
            Soldier sol2 = new Soldier(machineGunSemiautomatic, machineGunAut); //Injectamos al soldado las dos armas 
            sol2.Shoot("Disparar objetivo con Ametralladora Semiautomática");
            sol2.Shoot("Disparar objetivo con Ametralladora Automática");


        }
    }
}
