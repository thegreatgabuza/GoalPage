using GoalPage.Data;
using GoalPage.Models.Domain;
using GoalPage.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace GoalPage.Controllers
{
    public class GoalController : Controller
    {
        private readonly GoalPageDbContext goalPageDbContext;

        public GoalController(GoalPageDbContext goalPageDbContext)
        {
            this.goalPageDbContext = goalPageDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> MyGoalsList()
        {
        var goals = await goalPageDbContext.Goals.ToListAsync();
            return View(goals);
         }

        [HttpGet]
        public IActionResult AddGoal()
        {
            return View();
        } 

        [HttpPost]
        public async Task<IActionResult> AddGoal(AddGoalViewModel addGoalRequest)
        {
            var goal = new Goal()
            {
                Id = Guid.NewGuid(),
                Name = addGoalRequest.Name,
                WhatYouKnow = addGoalRequest.WhatYouKnow,
                WhatsOnTheMarket = addGoalRequest.WhatsOnTheMarket,
                WhatYouNeedToLearn = addGoalRequest.WhatYouNeedToLearn,
                CreatedDate = addGoalRequest.CreatedDate,

            };
          await goalPageDbContext.AddAsync(goal);
         await goalPageDbContext.SaveChangesAsync();
            return RedirectToAction("MyGoalsList");
         }
        
    }
}

