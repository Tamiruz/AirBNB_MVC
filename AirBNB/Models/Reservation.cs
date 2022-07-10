using AirBNB.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirBNB.Models
{
    public class Reservation
    {
        private int id;
        private int apartmentID;
        private int hostID;
        private int userID;
        private string from;
        private string to;
        private int price;
        private int nights;
        private string apartmentName;

        public Reservation(int id,int apartmentID, int hostID, int userID, string from, string to, int price, int nights, string apartmentName)
            : this (id, hostID, from, to, price, nights, apartmentName, apartmentID)
        {
            this.UserID = userID;
        }

        public Reservation(int id, int hostID,string from, string to, int price, int nights, string apartmentName,int apartmentID)
        {
            this.HostID = hostID;
            this.From = from;
            this.To = to;
            this.Id = id;
            this.ApartmentName = apartmentName;
            this.Price = price;
            this.Nights = nights;
            this.ApartmentID = apartmentID;
        }

        public Reservation(int userId, string from, string to, int apartmentID, string apartmentName, int hostId, int price)
            : this( apartmentID, hostId, userId,  from,  to)
        {
            this.ApartmentName = apartmentName;
            this.Price = price;

        }
        public Reservation(int apartmentID, int hostID, int userID, string from, string to)
            : this(apartmentID, from, to)
        {
            this.HostID = hostID;
            this.UserID = userID; 
        }

        public Reservation(int apartmentID,string from, string to)
        {
            this.ApartmentID = apartmentID;
            this.UserID = userID;
            this.From = from;
            this.To = to;
        }

        public Reservation(){}

        public int ApartmentID { get => apartmentID; set => apartmentID = value; }
        public int UserID { get => userID; set => userID = value; }
        public string From { get => from; set => from = value; }
        public string To { get => to; set => to = value; }
        public int Id { get => id; set => id = value; }
        public int HostID { get => hostID; set => hostID = value; }
        public int Price { get => price; set => price = value; }
        public int Nights { get => nights; set => nights = value; }
        public string ApartmentName { get => apartmentName; set => apartmentName = value; }

        public int reserveApartment()
        {
            DataServices ds = new DataServices();
            return ds.makeReservation(this);
        }

        public List<Reservation> getAllUserReservations(int id)
        {
            DataServices ds = new DataServices();
            return ds.getAllUserReservations(id);
        }

        public int cancelReservation()
        {
            DataServices ds = new DataServices();
            return ds.cancelReservation(this);
        }

    }
}