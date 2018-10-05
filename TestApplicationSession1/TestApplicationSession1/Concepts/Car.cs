/*
 References
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Class belonging to a domain is namespace. Ex: Car/Bus/Train belongs to an Automobile Domain.*/
namespace TestApplicationSession1.Concepts
{
    /*Any real world entity can be defined as a class.*/
    class Car
    {
        string Accelorator;
        string Brake;
        string Clutch;
        int gear;

        void Start()
        {
            
        }

        void Stop()
        {

        }

        float SpeedUp()
        {
            return 100f;
        }

        float SpeedDown()
        {
            return 100f;
        }
    }
}

