using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmpleadosApp.Data;
using EmpleadosApp.Models;
using EmpleadosApp.Repositories;

namespace EmpleadosApp.Pages;

public class EditModel : PageModel
{
    private readonly IEmpleadoRepository _empleadoRepository;

    public EditModel(IEmpleadoRepository empleadoRepository)
    {
        _empleadoRepository = empleadoRepository;
    }

    [BindProperty]
    public Empleado Empleado { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var empleado = await _empleadoRepository.GetByIdAsync(id.Value);
        if (empleado == null)
        {
            return NotFound();
        }

        Empleado = empleado;
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        try
        {
            await _empleadoRepository.UpdateAsync(Empleado);
        }
        catch
        {
            // Si el empleado no existe, devolver NotFound  
            if (await _empleadoRepository.GetByIdAsync(Empleado.Id) == null)
            {
                return NotFound();
            }
            throw;
        }

        return RedirectToPage("./Index");
    }
}