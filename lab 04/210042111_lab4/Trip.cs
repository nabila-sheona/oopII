using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210042111_lab4
{
    public enum VehicleType
    {
        SEDAN, MOTOR_BIKE, SEVEN_SEATER
    }
    public class Trip
    {
        private VehicleType vehilcletype;
        private int distanceKM;
        private int timeMinutes;
        private int numberOfPassengers;
        public Trip(VehicleType vehicleType,
            int distanceKM,
            int timeMinutes,
            int numberOfPassengers)
        {

            this.vehilcletype = vehicleType;
            this.distanceKM = distanceKM;
            this.timeMinutes = timeMinutes;
            this.numberOfPassengers = numberOfPassengers;


        }

        public int perheadfare()
        {

            int fare = 0;
            switch (vehilcletype)
            {
                case VehicleType.SEDAN:
                    fare = (50 + distanceKM * 30 + timeMinutes * 2) / numberOfPassengers;
                    break;

                case VehicleType.MOTOR_BIKE:

                    fare = Math.Max(25, distanceKM * 20) / numberOfPassengers;
                    break;

                default:
                    if (distanceKM < 10)
                        fare = 300 / numberOfPassengers;
                    else
                        fare = distanceKM * 30 / numberOfPassengers;
                    break;
            }

            return fare - (fare % 5);
        }

        public Boolean canTakeTrip()
        {
            if (numberOfPassengers < 1)
            {
                return false;
            }

            switch (vehilcletype)
            {
                case VehicleType.SEDAN:
                    return numberOfPassengers <= 4 && distanceKM <= 25;

                case VehicleType.SEVEN_SEATER:

                    return numberOfPassengers <= 7 && distanceKM >= 10;


                default: return numberOfPassengers <= 1 && distanceKM <= 10;

            }
        }


    }

}
