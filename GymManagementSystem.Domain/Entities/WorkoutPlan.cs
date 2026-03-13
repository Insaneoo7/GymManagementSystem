using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Domain.Entities
{
    public class WorkoutPlan
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        public int TrainerId { get; set; }

        public string MuscleGroup { get; set; }

        public Member Member { get; set; }

        public Trainer Trainer { get; set; }
    }
}
