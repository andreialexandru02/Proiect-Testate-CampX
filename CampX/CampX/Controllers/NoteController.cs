﻿using CampX.BusinessLogic.Implementations.Notes;
using CampX.BusinessLogic.Implementations.Notes.Models;
using CampX.BusinessLogic.Implementations.Reviews;
using CampX.BusinessLogic.Implementations.Reviews.Models;
using CampX.Code.Base;
using Microsoft.AspNetCore.Mvc;

namespace CampX.Controllers
{

    public class NoteController : BaseController
    {
        private readonly NoteService Service;

        public NoteController(ControllerDependencies dependencies, NoteService service)
           : base(dependencies)
        {
            this.Service = service;
        }

        public IActionResult AddNote(NoteModel model)
        {
           // Service.AddNote(model);

            return RedirectToAction("TripDetails", "trip", new { id = model.TripId });
        }
        [HttpGet]

        public IActionResult ShowNotes(int id)
        {
            return Json(Service.ShowNotes(id));
        }
    }
}