using AirBNB.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirBNB.Models
{
    public class Apartment
    {
        private int id;
        private string name;
        private string description;
        private string neighborhoodOverview;
        private string picture;
        private int hostID;
        private string since;
        private string hostResponseTime;
        private string hostNeighbourhood;
        private string location;
        private double x;
        private double y;
        private string propertyType;
        private int accommodates;
        private string roomType;
        private string bathroomsText;
        private int bedrooms;
        private int beds;
        private List<string> amenities;
        private int price;
        private int minNights;
        private int maxNights;
        private int availability365;
        private int numOfReviews; 
        private string lastReview;
        private double reviewRating;
        private double reviewCleanliness;
        private double reviewCommunication;
        private double reviewLocation;
        private int numOfRentals;
        private int count;
        private double distance;
        private int hostVerified;
        private int daysRented;
        private int numOfCancelation;
        //private Review[] reviews;


        public Apartment()
        {

        }

        public Apartment(int id, string name, string description, string neighborhoodOverview, string picture, int hostID, string since, string hostResponseTime, string hostNeighbourhood, string location, double x, double y, string propertyType, int accommodates, string roomType, string bathroomsText, int bedrooms, int beds, List<string> amenities, int price, int minNights, int maxNights, int availability365, int numOfReviews, string lastReview, double reviewRating, double reviewCleanliness, double reviewCommunication, double reviewLocation, double distance, int hostVerified)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.neighborhoodOverview = neighborhoodOverview;
            this.picture = picture;
            this.hostID = hostID;
            this.Since = since;
            this.hostResponseTime = hostResponseTime;
            this.hostNeighbourhood = hostNeighbourhood;
            this.location = location;
            this.x = x;
            this.y = y;
            this.propertyType = propertyType;
            this.accommodates = accommodates;
            this.roomType = roomType;
            this.bathroomsText = bathroomsText;
            this.bedrooms = bedrooms;
            this.beds = beds;
            this.Amenities = amenities;
            this.price = price;
            this.minNights = minNights;
            this.maxNights = maxNights;
            this.availability365 = availability365;
            this.numOfReviews = numOfReviews;
            this.lastReview = lastReview;
            this.reviewRating = reviewRating;
            this.reviewCleanliness = reviewCleanliness;
            this.reviewCommunication = reviewCommunication;
            this.reviewLocation = reviewLocation;
            this.numOfRentals = 0;
            this.distance = distance;
            this.HostVerified = hostVerified;
            Count = -1; //not from used apartment
        }

        // for first render.
        public Apartment(int id, string name, string description, string picture, int price, int numOfReviews, double reviewRating, int bedrooms, int accommodates)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.picture = picture;
            this.price = price;
            this.numOfReviews = numOfReviews;
            this.reviewRating = reviewRating;
            this.bedrooms = bedrooms;
            this.Accommodates = accommodates;

        }
    
        public Apartment(int id, string name, string description, string picture, int price, int numOfReviews, double reviewRating, int bedrooms, int accommodates, string location,int daysRented,int numOfCancelation)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.picture = picture;
            this.price = price;
            this.numOfReviews = numOfReviews;
            this.reviewRating = reviewRating;
            this.bedrooms = bedrooms;
            this.Accommodates = accommodates;
            this.Location = location;
            this.DaysRented = daysRented;
            this.NumOfCancelation = numOfCancelation;
        }

        public Apartment(string propertyType,  int count, string picture)
        {
            this.propertyType = propertyType;
            this.picture = picture;
            this.Count = count;
        }


        public Apartment(int minNights, int maxNights, int price)
        {
            this.minNights = minNights;
            this.maxNights = maxNights;
            this.Price = price;
        }

        public Apartment(int minNights, int maxNights, int price, string name)
        {
            this.minNights = minNights;
            this.maxNights = maxNights;
            this.Price = price;
            this.Name = name;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string NeighborhoodOverview { get => neighborhoodOverview; set => neighborhoodOverview = value; }
        public string Picture { get => picture; set => picture = value; }
        public int HostID { get => hostID; set => hostID = value; }
        public string HostResponseTime { get => hostResponseTime; set => hostResponseTime = value; }
        public string HostNeighbourhood { get => hostNeighbourhood; set => hostNeighbourhood = value; }
        public string Location { get => location; set => location = value; }
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public string PropertyType { get => propertyType; set => propertyType = value; }
        public string RoomType { get => roomType; set => roomType = value; }
        public string BathroomsText { get => bathroomsText; set => bathroomsText = value; }
        public int Bedrooms { get => bedrooms; set => bedrooms = value; }
        public int Beds { get => beds; set => beds = value; }
        public int Price { get => price; set => price = value; }
        public int MinNights { get => minNights; set => minNights = value; }
        public int MaxNights { get => maxNights; set => maxNights = value; }
        public int Availability365 { get => availability365; set => availability365 = value; }
        public int NumOfReviews { get => numOfReviews; set => numOfReviews = value; }
        public string LastReview { get => lastReview; set => lastReview = value; }
        public double ReviewRating { get => reviewRating; set => reviewRating = value; }
        public double ReviewCleanliness { get => reviewCleanliness; set => reviewCleanliness = value; }
        public double ReviewCommunication { get => reviewCommunication; set => reviewCommunication = value; }
        public double ReviewLocation { get => reviewLocation; set => reviewLocation = value; }
        public int NumOfRentals { get => numOfRentals; set => numOfRentals = value; }
        public string Since { get => since; set => since = value; }
        public int Count { get => count; set => count = value; }
        public List<string> Amenities { get => amenities; set => amenities = value; }
        public int Accommodates { get => accommodates; set => accommodates = value; }
        public double Distance { get => distance; set => distance = value; }
        public int HostVerified { get => hostVerified; set => hostVerified = value; }
        public int DaysRented { get => daysRented; set => daysRented = value; }
        public int NumOfCancelation { get => numOfCancelation; set => numOfCancelation = value; }


        //Getting a tiny apartments list to show in home page.
        public List<Apartment> getTinyList()
        {
            DataServices ds = new DataServices();
            return ds.getTinyList();
             
        }
        public List<Apartment> getAllPropertyType()
        {
            DataServices ds = new DataServices();
            return ds.getAllPropertyType();

        }

        public Apartment getApartmentByID(int id)
        {
            DataServices ds = new DataServices();
            return ds.getApartmentByID(id);
        }

        public List<Apartment> getAllApartmentsBySearch(string keyword, string from, string to, int minP, int maxP, double minD, double maxD, int beds, double rating)
        {
            DataServices ds = new DataServices();
            return ds.getAllApartmentsBySearch(keyword, from, to, minP, maxP, minD, maxD, beds, rating);
        }

        public List<Apartment> getAllApartmentsByPropertyType(string propertyType)
        {
            DataServices ds = new DataServices();
            return ds.getAllApartmentsByPropertyType(propertyType);
        }

        public List<Apartment> getAllApartments()
        {
            DataServices ds = new DataServices();
            return ds.getAllApartments();
        }

    }
}