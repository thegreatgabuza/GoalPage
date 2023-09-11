using System.ComponentModel.DataAnnotations;

namespace GoalPage.Models.Domain
{
    public class Goal
    {
        public Guid Id { get; set; }

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
