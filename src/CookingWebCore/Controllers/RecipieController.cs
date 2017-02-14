using CookingWebCore.Models;
using CookingWebCore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.EntityFrameworkCore;

namespace CookingWebCore.Controllers
{
    public class RecipieController : Controller
    {
        private readonly IRecipiesRepository _recipieRepository;
        private readonly IIngredientsRepository _ingredientRepository;
        private AppDbContext _context;


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
        public IActionResult Save(RecipieEditViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var newRecipie = new Recipie()
                {
                    Name = viewModel.RecipieName,
                    Preparation = viewModel.Preparation,
                    Fast = viewModel.Fast,
                    
                    
                    //IngredientId = viewModel.Ingredient,
                    Type = viewModel.FoodType,
                    Cuisine = viewModel.CuisineType,
                    //Ingredient = _context.Ingredients.Single(r => r.IngredientId == viewModel.Ingredient)
                    //Ingredient = _ingredientRepository.Ingredients.Single(r => r.IngredientId == viewModel.Ingredient),
                    //Id = 2
                  
                    

                };
                var selectedIngredients = viewModel.Ingredients.Where(x => x.checkBoxAnswer).Select(x => x.IngredientId).ToList();


                //for (int i = 0; i < viewModel.Ingredients.Count(); i++)
                //{
                //    if (viewModel.Ingredients[i].checkBoxAnswer == true)
                //    {
                //        newRecipie.RecipieIngredient = viewModel.Ingredients[i].RecipieIngredient;
                //    }
                //}

                //newRecipie.Name = model.Recipie.Name;
                //newRecipie.Cuisine = model.Recipie.Cuisine;
                //newRecipie.Preparation = model.Recipie.Preparation;
                //newRecipie.IngredientId= model.Recipie.IngredientId;
                //newRecipie.Type = model.Recipie.Type;
                //newRecipie.Fast = model.Recipie.Fast;



                // _context.Recipies.Add(newRecipie);
                _recipieRepository.Add(newRecipie);




                //_context.SaveChanges();


            }

            return RedirectToAction("List", "Recipie");

        }
    }
}
