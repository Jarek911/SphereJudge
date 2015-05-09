using StructureMap;
using StructureMap.Graph;

namespace SphereJudge.Spoj.Solutions
{
    public static class DefaultIoC
    {
        public static IContainer Container = Initialize();

        private static IContainer Initialize()
        {
            IContainer result = new Container();
            result.Configure(x => x.Scan(scan =>
            {
                scan.LookForRegistries();
                scan.AssembliesFromApplicationBaseDirectory();
                scan.WithDefaultConventions();
            }));
            return result;
        }
    }
}