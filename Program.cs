await Bootstrapper
    .Factory
    .CreateWeb(args)
    .AddSetting(WebKeys.Title, "My blog title")
    .AddSetting(WebKeys.Author, "The Author")
    .AddSetting(WebKeys.Description, "My blog's description")
    .RunAsync();