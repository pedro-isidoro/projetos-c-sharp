﻿using System;
using Course8.ReservationEntities.Exceptions;

namespace Course8.ReservationEntities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation() { 
        }
        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }
            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now)
            {
                throw new DomainException("Reservation dater for update must be to the future");
            }
            if (checkout <= checkin)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }
            Checkin = checkin;
            Checkout = checkout;
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", checkin: "
                + Checkin.ToString("dd/MM/yyyy")
                + ", checkout: "
                + Checkout.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}
