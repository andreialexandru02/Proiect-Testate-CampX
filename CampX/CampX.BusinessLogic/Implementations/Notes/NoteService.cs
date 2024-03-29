﻿using CampX.BusinessLogic.Base;
using CampX.BusinessLogic.Implementations.Map.Validations;
using CampX.BusinessLogic.Implementations.Notes.Models;
using CampX.BusinessLogic.Implementations.Notes.Validations;
using CampX.BusinessLogic.Implementations.Reviews.Models;
using CampX.BusinessLogic.Implementations.Reviews.Validations;
using CampX.Common.Extensions;
using CampX.DataAccess;
using CampX.Entities;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampX.BusinessLogic.Implementations.Notes
{
    public class NoteService : BaseService
    {

        private readonly NoteValidator NoteValidator;
        public NoteService(ServiceDependencies dependencies)
            : base(dependencies)
        {
            this.NoteValidator = new NoteValidator();
        }

        public List<ShowNoteModel> ShowNotes(int id) {

            var notes = UnitOfWork.Notes.Get()
                .Where(n => n.TripId == id)// && n.CamperId == CurrentCamper.Id) pentru afisare doar a note-urilor mele
                .Select(n => new ShowNoteModel
                {
                    Id = n.Id,
                    Content = n.Content,
                    TripId = n.TripId,
                    CamperId =  n.CamperId
                })
                .ToList();
            return notes;

        }
        public void AddNote(AddNoteModel model)
        {

            NoteValidator.Validate(model).ThenThrow();
            var note = Mapper.Map<AddNoteModel, Note>(model);

          

            UnitOfWork.Notes.Insert(note);

            UnitOfWork.SaveChanges();
        }
        public void DeleteNote(ShowNoteModel model)
        {
            UnitOfWork.Notes.Delete(
                UnitOfWork.Notes.Get()
                 .Where(n => n.Id == model.Id)
                 .SingleOrDefault()
            );
            UnitOfWork.SaveChanges();
        }
        public void EditNote(ShowNoteModel model)
        {


            var note = UnitOfWork.Notes.Get()
                .Where(c => c.Id == model.Id)
                .AsNoTracking()
                .SingleOrDefault();

            note = Mapper.Map<ShowNoteModel, Note>(model);

            UnitOfWork.Notes.Update(note);


            UnitOfWork.SaveChanges();
        }
        public bool CheckNoteOwner(int id)
        {
            return UnitOfWork.Notes.Get()
                .Where(r => r.Id == id)
                .Select(r => r.CamperId)
                .SingleOrDefault() == CurrentCamper.Id;
        }
        public bool IdOfTripExists(int id)
        {
            var trip = UnitOfWork.Trips.Get()
                .SingleOrDefault(r => r.Id == id);

            return trip != null;

        }
    }
}
