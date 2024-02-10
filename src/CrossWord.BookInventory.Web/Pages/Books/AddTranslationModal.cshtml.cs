using CrossWord.BookInventory.Books;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using Volo.Abp.Localization;

namespace CrossWord.BookInventory.Web.Pages.Books
{
    public class AddTranslationModal : BookInventoryPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        public List<SelectListItem> Languages { get; set; }

        [BindProperty]
        public BookTranslationViewModel TranslationViewModel { get; set; }

        private readonly IBookAppService _bookAppService;
        private readonly ILanguageProvider _languageProvider;

        public AddTranslationModal(
            IBookAppService bookAppService,
            ILanguageProvider languageProvider)
        {
            _bookAppService = bookAppService;
            _languageProvider = languageProvider;
        }

        public async Task OnGetAsync()
        {
            Languages = await GetLanguagesSelectItem();

            TranslationViewModel = new BookTranslationViewModel();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _bookAppService.AddTranslationsAsync(Id, ObjectMapper.Map<BookTranslationViewModel, AddBookTranslationDto>(TranslationViewModel));

            return NoContent();
        }

        private async Task<List<SelectListItem>> GetLanguagesSelectItem()
        {
            var result = await _languageProvider.GetLanguagesAsync();

            return result.Select(
                languageInfo => new SelectListItem
                {
                    Value = languageInfo.CultureName,
                    Text = languageInfo.DisplayName + " (" + languageInfo.CultureName + ")"
                }
            ).ToList();
        }

        public class BookTranslationViewModel
        {
            [Required]
            [SelectItems(nameof(Languages))]
            public string Language { get; set; }

            [Required]
            public string Name { get; set; }

        }
    }
}
