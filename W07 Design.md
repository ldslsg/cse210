          +-----------------------+
          |         Entry         |
          +-----------------------+
          | - Date (string)      |
          | - Prompt (string)    |
          | - Response (string)  |
          +-----------------------+
                  ^
                  |
                  |
          +-----------------------+
          |    PromptedEntry      |
          +-----------------------+
          | - List of Prompts     |  // Additional attribute
          | - AddPrompt()         |  // Method to add prompts
          | - SelectRandomPrompt()|  // Method to select a random prompt
          +-----------------------+
                  ^
                  |
                  |
          +-----------------------+
          |       Journal         |
          +-----------------------+
          | - List of Entries     |  // Additional attribute
          | - AddEntry()          |  // Method to add entries
          | - DisplayEntries()    |  // Method to display entries
          | - SaveJournalToFile() |  // Method to save the journal to a file
          | - LoadJournalFromFile()|  // Method to load the journal from a file
          +-----------------------+
Entry is the base class, representing a single journal entry. It has attributes for the date, the prompt, and the user's response.

PromptedEntry is a derived class, extending the base class Entry. It inherits the attributes from Entry and adds some additional attributes and methods. It has a list of prompts that can be used to provide users with daily prompts. The AddPrompt method allows for adding new prompts, and the SelectRandomPrompt method is used to randomly select a prompt for each new journal entry.

Journal is another derived class from Entry. Like PromptedEntry, it inherits the attributes of the base class Entry. However, Journal focuses on managing a collection of entries, so it has an additional attribute, which is a list to store multiple journal entries. The class provides methods like AddEntry to add new entries to the journal, DisplayEntries to display all entries, SaveJournalToFile to save the journal to a file, and LoadJournalFromFile to load the journal from a file. This class is responsible for managing and interacting with multiple journal entries.

In summary, PromptedEntry and Journal are both derived classes from the base class Entry. They inherit attributes and methods from the base class and add their own specific attributes and methods to fulfill their unique purposes in the program.