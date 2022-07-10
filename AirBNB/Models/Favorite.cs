using AirBNB.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirBNB.Models
{
    public class Favorite
    {
        private int userId;
        private int apartmentId;

        public Favorite(int userId, int apartmentId)
        {
            this.UserId = userId;
            this.ApartmentId = apartmentId;
        }

        public Favorite()
        {

        }

        public int UserId { get => userId; set => userId = value; }
        public int ApartmentId { get => apartmentId; set => apartmentId = value; }

        public int insertFavorite()
        {
            DataServices ds = new DataServices();
            return ds.insertFavorite(this);
        }

        public List<Favorite> deleteFromFavorite()
        {
            DataServices ds = new DataServices();
            return ds.deleteFromFavorite(this);
        }

        public List<Favorite> getAllFavorites(int userId)
        {
            DataServices ds = new DataServices();
            return ds.getAllFavorites(userId);
        }

        public List<Apartment> getAllApartmentsFavorites(int userId)
        {
            DataServices ds = new DataServices();
            return ds.getAllApartmentsFavorites(userId);
        }
    }
}