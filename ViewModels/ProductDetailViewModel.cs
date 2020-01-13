using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;

namespace BethanysPieShop.ViewModels
{
    public class ProductDetailViewModel
    {
        public Pie ProductDetail { get; set; }

        // behöver skapa <List> av kommentarerna för att kunna 
        // kontrollera antalet kommentarer i html-koden

        // genomsnittsbetyg beräknas och formatteras 
        // innan det skickas till webben
        public string GradeAverage { get; set; }
    }
}
