using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using System;

namespace Jellyfin.Plugin.TmdbTagSync;

public class Plugin : BasePlugin<PluginConfiguration>, IHasWebPages
{
    public override string Name => "TMDB Tag Sync";

    public override Guid Id => Guid.Parse("c1c9fbd7-3bb5-4df3-b36c-29f8efeb0f72");

    public Plugin(IServiceProvider applicationPaths)
        : base(applicationPaths)
    {
        Instance = this;
    }

    public static Plugin? Instance { get; private set; }

    public IEnumerable<PluginPageInfo> GetPages()
    {
        return new[]
        {
            new PluginPageInfo
            {
                Name = "tmdbtagsync",
                EmbeddedResourcePath = $"{GetType().Namespace}.Web.configPage.html"
            }
        };
    }
}