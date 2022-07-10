using AirBNB.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirBNB.Models
{
    public class Review
    {
        private int listing_id;
        private int id;
        private string date;
        private int reviewerID;
        private string reviewerName;
        private string revComment;
        public static int revCounter = 0;

        public Review(int listing_id, int id, string date, int reviewerID, string reviewerName, string revComment)
        {
            this.Listing_id = listing_id;
            this.Id = id;
            this.Date = date;
            this.ReviewerID = reviewerID;
            this.ReviewerName = reviewerName;
            this.RevComment = revComment;
            revCounter++;
        }

        public Review()
        {

        }

        public int Listing_id { get => listing_id; set => listing_id = value; }
        public int Id { get => id; set => id = value; }
        public string Date { get => date; set => date = value; }
        public int ReviewerID { get => reviewerID; set => reviewerID = value; }
        public string ReviewerName { get => reviewerName; set => reviewerName = value; }
        public string RevComment { get => revComment; set => revComment = value; }

        public List<Review> getAllApartmentReviews(int id)
        {
            DataServices ds = new DataServices();
            return ds.getAllApartmentReviews(id);
        }

        public int insertReview()
        {
            DataServices ds = new DataServices();
            return ds.insertReview(this);
        }
    }
}