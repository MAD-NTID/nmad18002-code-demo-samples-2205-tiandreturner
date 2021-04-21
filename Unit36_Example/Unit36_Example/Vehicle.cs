using System;

namespace Unit36_Example {
    public class Vehicle {
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="_plate">License Plate Number</param>
        /// <param name="_plateState">License Plate State</param>
        /// <param name="_permitNumber">Permit Number</param>
        /// <param name="_firstName">Owner's First Name</param>
        /// <param name="_lastName">Owner's Last name</param>
        /// <param name="_type">Vehicle Type from Vehicle Type enum</param>
        public Vehicle(string _plate, string _plateState, int _permitNumber, 
                       string _firstName, string _lastName, Vehicle_Type _type) {
            PlateNumber = _plate;
            PlateState = _plateState;
            PermitNumber = _permitNumber;
            OwnerFirstName = _firstName;
            OwnerLastName = _lastName;
            Type = _type;
        }

        /// <summary>
        /// Alphanumeric code on the license plate
        /// </summary>
        public string PlateNumber { get; set; }

        /// <summary>
        /// First Name of Owner
        /// </summary>
        public string OwnerFirstName { get; set; }
        
        /// <summary>
        /// Last Name of Owner
        /// </summary>
        public string OwnerLastName { get; set; }
 
        /// <summary>
        /// State in which plate was issued
        /// </summary>
        public string PlateState { get; set; }
 
        /// <summary>
        /// Vehicle Type
        /// </summary>
        public Vehicle_Type Type { get; set; }
 
        /// <summary>
        /// Permit Number
        /// </summary>
        public int PermitNumber { get; set; }
 
        /// <summary>
        /// Creates formatted string
        /// </summary>
        /// <remarks>Returns Permit/Plate/State/Vehicle Type/Full Name</remarks>
        public override string ToString() {
            string buildit;
            buildit = string.Format("{0,-10} {1,-10} {2,-10} {3,-12} {4,-25}",
                                    PermitNumber, PlateNumber, PlateState, Type, Owner());
            return buildit;
        }

        /// <summary>
        /// Returns owner's full name (last, first)
        /// </summary>
        public string Owner() {
            return $"{OwnerLastName},{OwnerFirstName}";
        }

        /// <summary>
        /// Returns plate number, plate state, and type
        /// </summary>
        public string Description() {
            return $"{PlateNumber}-{PlateState} {Type.ToString()}";
        }
    }
}