﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DAL.Models;

namespace CSPharma_JuancaV3.Pages.LineasDistribucion
{
    public class DetailsModel : PageModel
    {
        private readonly DAL.Models.CspharmaInformacionalContext _context;

        public DetailsModel(DAL.Models.CspharmaInformacionalContext context)
        {
            _context = context;
        }

      public TdcCatLineasDistribucion TdcCatLineasDistribucion { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.TdcCatLineasDistribucions == null)
            {
                return NotFound();
            }

            var tdccatlineasdistribucion = await _context.TdcCatLineasDistribucions.FirstOrDefaultAsync(m => m.CodLinea == id);
            if (tdccatlineasdistribucion == null)
            {
                return NotFound();
            }
            else 
            {
                TdcCatLineasDistribucion = tdccatlineasdistribucion;
            }
            return Page();
        }
    }
}
