using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_task1_alt
{
    public enum Vehicletype{
        SEDAN, MOTORBIKE, SEVENSEATER
    }

    public class Trip
    {
        private IFareCalc farecalc;
        Vehicletype vehicle;
        int distance;
        int time;
        int numberofpassengers;
        public Trip(Vehicletype vehicle, int distance, int time, int numberofpassengers)
        {
            this.vehicle = vehicle;
            this.distance = distance;
            this.time = time;
            this.numberofpassengers = numberofpassengers;
         
            switch (vehicle)
            {
                case Vehicletype.SEDAN:
                    farecalc = new sedan();
                    break;

                case Vehicletype.MOTORBIKE:

                    farecalc = new motorbike();
                    break;

                default:
                    farecalc = new defaultvehicle();
                    break;
            }

          
        }


        public int perheadfare()
        {
            int fare = farecalc.calcfare(distance, time, numberofpassengers);

           return fare - (fare%5);
        }

        public Boolean canTakeTrip()
        {
            if (numberofpassengers < 1)
            {
                return false;
            }

            switch (vehicle)
            {
                case Vehicletype.SEDAN:
                    return numberofpassengers <= 4 && distance <= 25;

                case Vehicletype.SEVENSEATER:

                    return numberofpassengers <= 7 && distance >= 10;


                default: return numberofpassengers <= 1 && distance <= 10;

            }
        }

    }


   
}
