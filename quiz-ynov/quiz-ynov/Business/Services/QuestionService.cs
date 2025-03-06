using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using quiz_ynov.Business.Models;
using quiz_ynov.Controllers.Dtos;

namespace quiz_ynov.Business.Services
{
    public class QuestionService: IQuestionService
    {
        private List<Question> _questionList = new List<Question>
    {
        new Question
        {
            Id = new Guid("1f6dcd89-6e5b-4cfb-9c1a-f5e7b78a9dcd"),
            Content = "What is ASP.NET Core?",
            Quiz = new Quiz{Id= new Guid("ae9fcd19-9da1-4cbb-8e16-e9af9fd2f3aa")},
            Choices = new List<string> { "Framework", "Programming Language", "IDE" },
            CorrectAnswer = "Framework"
        },
        
        new Question
        {
            Id = new Guid("2e4dcf93-1e5a-4acb-8c7a-3b7f9a3b8cdd"),
            Content = "What is the primary language used in ASP.NET Core?",
            Quiz = new Quiz { Id = new Guid("ae9fcd19-9da1-4cbb-8e16-e9af9fd2f3aa") },
            Choices = new List<string> { "C#", "Python", "JavaScript" },
            CorrectAnswer = "C#"
        },
        new Question
        {
            Id = new Guid("3f9acd71-2d4b-4eef-9c7d-1a2b7f3b8cfe"),
            Content = "Which middleware is used for handling routing in ASP.NET Core?",
            Quiz = new Quiz { Id = new Guid("ae9fcd19-9da1-4cbb-8e16-e9af9fd2f3aa") },
            Choices = new List<string> { "Routing Middleware", "Authentication Middleware", "Session Middleware" },
            CorrectAnswer = "Routing Middleware"
        },
        new Question
        {
            Id = Guid.NewGuid(),
            Content = "What is Dependency Injection in ASP.NET Core?",
            Quiz = new Quiz { Id = new Guid("ae9fcd19-9da1-4cbb-8e16-e9af9fd2f3aa") },
            Choices = new List<string> { "A design pattern", "A database", "An algorithm" },
            CorrectAnswer = "A design pattern"
        },
        new Question
        {
            Id = Guid.NewGuid(),
            Content = "Which command is used to create a new ASP.NET Core project?",
            Quiz = new Quiz { Id = new Guid("ae9fcd19-9da1-4cbb-8e16-e9af9fd2f3aa") },
            Choices = new List<string> { "dotnet new mvc", "dotnet start", "dotnet create project" },
            CorrectAnswer = "dotnet new mvc"
        },

        // Questions for "csharp-advanced" quiz
        new Question
        {
            Id = Guid.NewGuid(),
            Content = "What is the purpose of the 'using' statement in C#?",
            Quiz = new Quiz { Id = new Guid("f72d3207-d748-4fd4-909d-36f50f848fc3") },
            Choices = new List<string> { "Namespace import", "Memory management", "Loop control" },
            CorrectAnswer = "Memory management"
        },
        new Question
        {
            Id = Guid.NewGuid(),
            Content = "What is the difference between 'ref' and 'out' parameters in C#?",
            Quiz = new Quiz { Id = new Guid("f72d3207-d748-4fd4-909d-36f50f848fc3") },
            Choices = new List<string> { "'out' must be initialized before usage, 'ref' must not", "Both are the same", "'ref' is for output, 'out' is for input" },
            CorrectAnswer = "'out' must be initialized before usage, 'ref' must not"
        },
        new Question
        {
            Id = Guid.NewGuid(),
            Content = "What is a C# delegate?",
            Quiz = new Quiz { Id = new Guid("f72d3207-d748-4fd4-909d-36f50f848fc3") },
            Choices = new List<string> { "A reference type", "A value type", "An operator" },
            CorrectAnswer = "A reference type"
        },
        new Question
        {
            Id = Guid.NewGuid(),
            Content = "What keyword is used to define an anonymous method in C#?",
            Quiz = new Quiz { Id = new Guid("f72d3207-d748-4fd4-909d-36f50f848fc3") },
            Choices = new List<string> { "delegate", "lambda", "anonymous" },
            CorrectAnswer = "delegate"
        },

        // Questions for "intro-python" quiz
        new Question
        {
            Id = Guid.NewGuid(),
            Content = "Which keyword is used to define a function in Python?",
            Quiz = new Quiz { Id = new Guid("c9b5b9b9-b91f-4bc9-9b9f-7a876ff55a5f") },
            Choices = new List<string> { "func", "define", "def" },
            CorrectAnswer = "def"
        },
        new Question
        {
            Id = Guid.NewGuid(),
            Content = "What is the output of 'print(type([]))' in Python?",
            Quiz = new Quiz { Id = new Guid("c9b5b9b9-b91f-4bc9-9b9f-7a876ff55a5f") },
            Choices = new List<string> { "<class 'list'>", "<class 'tuple'>", "<class 'dict'>" },
            CorrectAnswer = "<class 'list'>"
        },
        new Question
        {
            Id = Guid.NewGuid(),
            Content = "Which symbol is used for single-line comments in Python?",
            Quiz = new Quiz { Id = new Guid("c9b5b9b9-b91f-4bc9-9b9f-7a876ff55a5f") },
            Choices = new List<string> { "//", "#", "--" },
            CorrectAnswer = "#"
        },
        new Question
        {
            Id = Guid.NewGuid(),
            Content = "What data type is returned by the input() function in Python?",
            Quiz = new Quiz { Id = new Guid("c9b5b9b9-b91f-4bc9-9b9f-7a876ff55a5f") },
            Choices = new List<string> { "int", "str", "float" },
            CorrectAnswer = "str"
        },

            // Programming Basics
            new Question
        {
            Id = Guid.NewGuid(),
            Content = "What keyword is used to define a constant variable in C#?",
            Quiz = new Quiz { Id = new Guid("b2b345e3-f12c-4e68-8b78-a6d84e7074c9") },
            Choices = new List<string> { "const", "static", "readonly" },
            CorrectAnswer = "const"
        },
        new Question
        {
            Id = Guid.NewGuid(),
            Content = "Which data type is used to store decimal numbers in C#?",
            Quiz = new Quiz { Id = new Guid("b2b345e3-f12c-4e68-8b78-a6d84e7074c9") },
            Choices = new List<string> { "float", "double", "decimal" },
            CorrectAnswer = "double"
        },
        new Question
        {
            Id = Guid.NewGuid(),
            Content = "Which loop executes at least once in C#?",
            Quiz = new Quiz { Id = new Guid("b2b345e3-f12c-4e68-8b78-a6d84e7074c9") },
            Choices = new List<string> { "for", "while", "do-while" },
            CorrectAnswer = "do-while"
        },
        new Question
        {
            Id = Guid.NewGuid(),
            Content = "What is the default access modifier in C#?",
            Quiz = new Quiz { Id = new Guid("b2b345e3-f12c-4e68-8b78-a6d84e7074c9") },
            Choices = new List<string> { "private", "public", "internal" },
            CorrectAnswer = "private"
        },
        // js-web
        new Question
        {
            Id = Guid.NewGuid(),
            Content = "Which keyword is used to declare a variable in JavaScript?",
            Quiz = new Quiz { Id = new Guid("92b8e6e4-48d5-4781-a7e1-29b84942f3e5") },
            Choices = new List<string> { "var", "int", "declare" },
            CorrectAnswer = "var"
        },
        new Question
        {
            Id = Guid.NewGuid(),
            Content = "Which function is used to print something in the browser console?",
            Quiz = new Quiz { Id = new Guid("92b8e6e4-48d5-4781-a7e1-29b84942f3e5") },
            Choices = new List<string> { "console.write()", "print()", "console.log()" },
            CorrectAnswer = "console.log()"
        },
        new Question
        {
            Id = Guid.NewGuid(),
            Content = "Which symbol is used for strict equality comparison in JavaScript?",
            Quiz = new Quiz { Id = new Guid("92b8e6e4-48d5-4781-a7e1-29b84942f3e5") },
            Choices = new List<string> { "==", "===", "!=" },
            CorrectAnswer = "==="
        },
        new Question
        {
            Id = Guid.NewGuid(),
            Content = "Which event fires when a user clicks on an element?",
            Quiz = new Quiz { Id = new Guid("92b8e6e4-48d5-4781-a7e1-29b84942f3e5") },
            Choices = new List<string> { "onchange", "onclick", "onhover" },
            CorrectAnswer = "onclick"
        },
             // Questions pour Artificial Intelligence
             //ml-intro 
            new Question
        {
            Id = Guid.NewGuid(),
            Content = "What is the primary goal of machine learning?",
            Quiz = new Quiz { Id = new Guid("e5f6b2d7-a4f7-4bb9-bd6c-63f9f5f73ac9") },
            Choices = new List<string> { "Manual feature engineering", "Pattern recognition", "Predefined rules" },
            CorrectAnswer = "Pattern recognition"
        },
        new Question
        {
            Id = Guid.NewGuid(),
            Content = "Which algorithm is commonly used for classification tasks?",
            Quiz = new Quiz { Id = new Guid("e5f6b2d7-a4f7-4bb9-bd6c-63f9f5f73ac9") },
            Choices = new List<string> { "K-Means", "Decision Tree", "Gradient Descent" },
            CorrectAnswer = "Decision Tree"
        },
        new Question
        {
            Id = Guid.NewGuid(),
            Content = "Which library is most commonly used for deep learning?",
            Quiz = new Quiz { Id = new Guid("e5f6b2d7-a4f7-4bb9-bd6c-63f9f5f73ac9") },
            Choices = new List<string> { "Pandas", "TensorFlow", "NumPy" },
            CorrectAnswer = "TensorFlow"
        },
        new Question
        {
            Id = Guid.NewGuid(),
            Content = "Which step is essential in supervised learning?",
            Quiz = new Quiz { Id = new Guid("e5f6b2d7-a4f7-4bb9-bd6c-63f9f5f73ac9") },
            Choices = new List<string> { "Labeling data", "Random guessing", "Ignoring outliers" },
            CorrectAnswer = "Labeling data"
        },
        //nn-basic 
        new Question
        {
            Id = Guid.NewGuid(),
            Content = "What is an artificial neuron inspired by?",
            Quiz = new Quiz { Id = new Guid("c1f3b2d1-d8e2-4d1b-b7e5-6a3a7f6f2f3b") },
            Choices = new List<string> { "Electric circuit", "Biological neuron", "Mathematical equation" },
            CorrectAnswer = "Biological neuron"
        },
        new Question
        {
            Id = Guid.NewGuid(),
            Content = "Which activation function is commonly used in deep learning?",
            Quiz = new Quiz { Id = new Guid("c1f3b2d1-d8e2-4d1b-b7e5-6a3a7f6f2f3b") },
            Choices = new List<string> { "ReLU", "Softmax", "Sigmoid" },
            CorrectAnswer = "ReLU"
        },
        new Question
        {
            Id = Guid.NewGuid(),
            Content = "What is backpropagation used for?",
            Quiz = new Quiz { Id = new Guid("c1f3b2d1-d8e2-4d1b-b7e5-6a3a7f6f2f3b") },
            Choices = new List<string> { "Predicting outputs", "Adjusting weights", "Creating new neurons" },
            CorrectAnswer = "Adjusting weights"
        },
        new Question
        {
            Id = Guid.NewGuid(),
            Content = "Which framework is popular for training neural networks?",
            Quiz = new Quiz { Id = new Guid("c1f3b2d1-d8e2-4d1b-b7e5-6a3a7f6f2f3b") },
            Choices = new List<string> { "TensorFlow", "Jupyter Notebook", "Excel" },
            CorrectAnswer = "TensorFlow"
        },

            // Questions pour Mobile Development (Android & iOS)
            new Question
            {
                Id = new Guid("7b9d8a8f-93da-4b8f-9536-71bb9d69f8f2"),
                Content = "Which language is primarily used for Android development?",
                Quiz = new Quiz { Id = new Guid("e9d5a7c9-7a2f-4e7d-8f19-18f0e9c0f5a7") },
                Choices = new List<string> { "Kotlin", "Swift", "Objective-C" },
                CorrectAnswer = "Kotlin"
            },
            new Question
            {
                Id = new Guid("3bbddcdc-bf65-47f4-9c3e-02c9299c6e2a"),
                Content = "Which IDE is primarily used for Android app development?",
                Quiz = new Quiz { Id = new Guid("e9d5a7c9-7a2f-4e7d-8f19-18f0e9c0f5a7") },
                Choices = new List<string> { "Visual Studio", "Xcode", "Android Studio" },
                CorrectAnswer = "Android Studio"
            },
            new Question
            {
                Id = new Guid("2e1f9e65-9f5d-49ab-8b61-d20f58e6c32c"),
                Content = "What is used to design the user interface in iOS?",
                Quiz = new Quiz { Id = new Guid("f1d9b6e7-d1e3-44e4-9345-1b4f5e3a5b3d") },
                Choices = new List<string> { "Android Studio", "Xcode", "JetBrains" },
                CorrectAnswer = "Xcode"
            }

            };

        public IEnumerable<Question> GetAll()
        {
            return _questionList;
        }

        public Question GetById(Guid id)
        {
            return _questionList.FirstOrDefault(question => question.Id == id);
        }





        public int ScoreCalcul(List<ResponseDto> userResponses)
        {
            int score = 0;

            // Parcourir chaque réponse de l'utilisateur
            for (int i = 0; i < userResponses.Count; i++)
            {
                // Récupérer la réponse de l'utilisateur
                var userResponse = userResponses[i];

                // Parcourir la liste des questions
                for (int j = 0; j < _questionList.Count; j++)
                {
                    // Comparer l'ID de la question avec celui de la réponse
                    if (_questionList[j].Id.ToString() == userResponse.QuestionId)
                    {
                        // Si l'ID correspond, comparer les réponses
                        if (_questionList[j].CorrectAnswer == userResponse.Response)
                        {
                            score++; // Incrémenter le score si la réponse est correcte
                        }
                        break; // Sortir de la boucle interne une fois la question trouvée
                    }
                }
            }

            return score;
        }


    }
}
