using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Domain.Entities
{
    public class DietPlan
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        public int TrainerId { get; set; }

        public string MealType { get; set; } // Breakfast, Lunch, Dinner

        public string FoodItems { get; set; }

        public Member Member { get; set; }

        public Trainer Trainer { get; set; }
    }
}
