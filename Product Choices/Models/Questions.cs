using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Product_Choices.Models
{
    public class Questions1
    {
        public int Id { get; set; }

        public string pid { get; set; }

        [Display(Name = "The products I chose reflect my normal consumption choices")]
        [UIHint("Question")]
        public int? Question1 { get; set; }

        [Display(Name = "I chose the products that looked the most visually appealing")]
        [UIHint("Question")]
        public int? Question2 { get; set; }

        [Display(Name = "I chose the products that looked the most like what I would normally buy")]
        [UIHint("Question")]
        public int? Question3 { get; set; }

        [Display(Name = "I chose the products with the greatest nutritional value")]
        [UIHint("Question")]
        public int? Question4 { get; set; }

        [Display(Name = "I chose the products using a reasoned, analytical approach")]
        [UIHint("Question")]
        public int? Question5 { get; set; }

        [Display(Name = "I chose the products using my initial gut instinct")]
        [UIHint("Question")]
        public int? Question6 { get; set; }

        [Display(Name = "I found the task stimulating and enjoyable")]
        [UIHint("Question")]
        public int? Question7 { get; set; }

        [Display(Name = "I found the task straightforward and easy to understand")]
        [UIHint("Question")]
        public int? Question8 { get; set; }

        [Display(Name = "Do you have any suggestions for improving the Product Choice Task or any comments you would like to make about the task?")]
        [MaxLength(600, ErrorMessage = "Please limit your response to 600 characters")]
        public string Question10 { get; set; }

    }

    public class Questions2
    {
        public int Id { get; set; }

        public string pid { get; set; }

        [Display(Name = "Branded products are usually higher quality")]
        [UIHint("Question")]
        public int? Question1 { get; set; }

        [Display(Name = "House brands are usually cheaper")]
        [UIHint("Question")]
        public int? Question2 { get; set; }

        [Display(Name = "Branded products are usually healthier")]
        [UIHint("Question")]
        public int? Question3 { get; set; }

        [Display(Name = "Price is an important factor when choosing which product to buy")]
        [UIHint("Question")]
        public int? Question4 { get; set; }

        [Display(Name = "I am an image conscious person")]
        [UIHint("Question")]
        public int? Question5 { get; set; }

        [Display(Name = "Branded and house brand products usually taste the same")]
        [UIHint("Question")]
        public int? Question6 { get; set; }

        [Display(Name = "House brand products are usually just as good as more expensive brands")]
        [UIHint("Question")]
        public int? Question7 { get; set; }

        [Display(Name = "If something is healthy, price is not an issue")]
        [UIHint("Question")]
        public int? Question8 { get; set; }

        [Display(Name = "I am a health conscious person")]
        [UIHint("Question")]
        public int? Question9 { get; set; }

        [Display(Name = "I usually try to seek out bargain products")]
        [UIHint("Question")]
        public int? Question10 { get; set; }
    }
}