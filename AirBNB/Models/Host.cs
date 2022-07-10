using AirBNB.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirBNB.Models
{
    public class Host
    {
        private int numOfApartments;
        private int totalIncome;
        private int numOfCancelation;
        private int id;
        private string name;

        public Host(int numOfApartments, int totalIncome, int numOfCancelation, int id, string name)
        {
            this.numOfApartments = numOfApartments;
            this.totalIncome = totalIncome;
            this.numOfCancelation = numOfCancelation;
            this.id = id;
            this.name = name;
        }

        public Host()
        {

        }

        public  int NumOfApartments { get => numOfApartments; set => numOfApartments = value; }
        public  int TotalIncome { get => totalIncome; set => totalIncome = value; }
        public  int NumOfCancelation { get => numOfCancelation; set => numOfCancelation = value; }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public List<Host> getAllHosts()
        {
            DataServices ds = new DataServices();
            return ds.getAllHosts();
        }
    }
}