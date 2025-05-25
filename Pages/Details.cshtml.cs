using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmpleadosApp.Data;
using EmpleadosApp.Models;
using EmpleadosApp.Repositories;

namespace EmpleadosApp.Pages;

public class DetailsModel : PageModel
{
    private readonly IEmpleadoRepository _empleadoRepository;

    public DetailsModel(IEmpleadoRepository empleadoRepository)
    {
        _empleadoRepository = empleadoRepository;
    }

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
}