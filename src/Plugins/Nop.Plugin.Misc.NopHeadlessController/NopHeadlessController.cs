using System.Threading.Tasks;
using Nop.Services.Plugins;

namespace Nop.Plugin.Misc.NopHeadlessController
{
    public class NopHeadlessController : BasePlugin
    {

        public override Task InstallAsync()
        {
            return base.InstallAsync();
        }

        public override Task UninstallAsync()
        {
            return base.UninstallAsync();
        }
    }
}