using CookingWebCore.Models;
using CookingWebCore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingWebCore.Controllers
{
    public class RecipieController : Controller
    {
        private readonly IRecipiesRepository _recipieRepository;
        private readonly IIngredientsRepository _ingredientRepository;

        public RecipieController(IRecipiesRepository recipieRepository,IIngredientsRepository ingredientsRepository)
        {
            _recipieRepository = recipieRepository;
            _ingredientRepository = ingredientsRepository;

        }

        public ViewResult List()
        {
            RecipiesListViewModel recipiesListViewModel = new RecipiesListViewModel();
            recipiesListViewModel.Recipies = _recipieRepository.Recipies;

            return View(recipiesListViewModel);
        }

        public ViewResult New()
        {
            var ingredients = _ingredientRepository.Ingredients.ToList();

            var viewModel = new RecipieEditViewModel()
            {
                Ingredients = ingredients
            };
            return View("Create", viewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Create(RecipieEditViewModel model)
        {
            var newRecipie = new Recipie();
            newRecipie.RecipieName = model.RecipieName;
            newRecipie.Cuisine = model.CuisineType;

            return View(newRecipie);
            
        }
    }
}
