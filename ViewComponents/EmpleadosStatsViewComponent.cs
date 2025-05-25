using EmpleadosApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmpleadosApp.ViewComponents
{
    public class EmpleadosStatsViewComponent : ViewComponent
    {
        private readonly IEmpleadoRepository _empleadoRepository;

        public EmpleadosStatsViewComponent(IEmpleadoRepository empleadoRepository)
        {
            _empleadoRepository = empleadoRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var viewModel = new EmpleadosStatsViewModel
            {
                ActiveCount = await _empleadoRepository.GetActiveCountAsync(),
                InactiveCount = await _empleadoRepository.GetInactiveCountAsync()
            };

            return View(viewModel);
        }
    }

    public class EmpleadosStatsViewModel
    {
        public int ActiveCount { get; set; }
        public int InactiveCount { get; set; }
    }
}