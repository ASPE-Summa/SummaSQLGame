﻿using Microsoft.EntityFrameworkCore;
using SummaSQLGame.Helpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SummaSQLGame.Models
{
    [Table("land")]
    [PrimaryKey("Id")]
    public class Country : ObservableObject
    {
        private readonly int _id;
        private string _name;
        private string _continent;
        private ICollection<City> _cities;

        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get { return _id; } }

        [Column("naam")]
        [StringLength(255)]
        public string Name { get { return _name; } set { _name = value; OnPropertyChanged(); } }

        public ICollection<City> Cities { get { return _cities; } set { _cities = value; OnPropertyChanged(); } }
    }
}