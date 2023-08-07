using System;

namespace rest_simple.Models;

public record Message(string role, string content);
public record Choice(string text, int index, string finish_reason);
public record Usage(int completion_tokens, int prompt_tokens, int total_tokens);
public record Completion(string id, string @object, Choice[] choices, Usage usage);
