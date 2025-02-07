using OpenQA.Selenium.BiDi.Communication;

#nullable enable

namespace OpenQA.Selenium.BiDi.Modules.Browser;

internal class RemoveUserContextCommand(RemoveUserContextCommandParameters @params) : Command<RemoveUserContextCommandParameters>(@params);

internal record RemoveUserContextCommandParameters(UserContext UserContext) : CommandParameters;

public record RemoveUserContextOptions : CommandOptions;
