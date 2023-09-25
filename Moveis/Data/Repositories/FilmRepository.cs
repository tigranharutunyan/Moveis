﻿using Moveis.Data.Entity;
using Moveis.Data.Repositories.Interface;

namespace Moveis.Data.Repositories
{
    public class FilmRepository:IFilmRepostory
    {
        private readonly MyFilmContext _filmContext;
        public FilmRepository(MyFilmContext filmContext)
        {
            _filmContext = filmContext;
        }

        public void Add(Film film)
        {   
            _filmContext.Add(film);
            _filmContext.SaveChanges();
            
        }

        public void Delete(Film film)
        {
           _filmContext.Remove(film);
            _filmContext.SaveChanges();    
        }

        public List<Film> GetAll()
        {
            return  _filmContext.Films.ToList();
        }

        public Film GetById(int id)
        {
            return _filmContext.Films.Find(id);
        }

        public void SaveChanges()
        {
            _filmContext.SaveChanges();
        }
    }
}
