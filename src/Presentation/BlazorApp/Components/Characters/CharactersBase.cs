using Business.Interfaces.Characters;
using DataAccess.Interfaces.CrossCutting;
using Entities.Characters;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Components.Characters
{
    public class CharactersBase : ComponentBase
    {
        private int page = 1;
        public Paginated<Character>? Characters { get; set; }


        [Inject]
        protected ICharacterService Service { get; set; }

        protected async override Task OnInitializedAsync()
        {
            base.OnInitialized();

            Characters = await Service.GetAllAsync(page);
        }
    }
}
