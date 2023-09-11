using System.ComponentModel.DataAnnotations;

namespace GoalPage.Models
{
    public class AddGoalViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string WhatYouKnow { get; set; }

        [Required]
        public string WhatsOnTheMarket { get; set; }

        [Required]
        public string WhatYouNeedToLearn { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
