// POCOs
record Message(string role, string content);
record Choice(string text, int index, string finish_reason);
record Usage(int completion_tokens, int prompt_tokens, int total_tokens);
record Completion(string id, string @object, Choice[] choices, Usage usage);
