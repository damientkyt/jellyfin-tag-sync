using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.TmdbTagSync;

public class PluginConfiguration : BasePluginConfiguration
{
    public string TmdbApiKey { get; set; } = "";
}