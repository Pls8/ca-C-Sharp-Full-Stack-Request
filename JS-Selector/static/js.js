// document.getElementById("h2id").style.color = "red";
// document.getElementsByClassName("h2class")[0].style.color = "blue";
// document.querySelector("h2").style.color = "purple";

// let h2id = document.getElementById("h2id");
// let h2class = document.getElementsByClassName("h2class")[0].textContent;
// let h2 = document.querySelector("h2");
// h2class.innerHTML = "Inner Html Selector H2 Class";
// console.log(h2id);
// console.log(h2class);
// console.log(h2);

// let h2S1 = document.querySelector("h2class");
// let h2S2 = document.querySelector("h2id");
// let h2S3 = document.querySelectorAll("h2");
// console.log(h2S1);
// console.log(h2S2);
// console.log(h2S3);

// let divEvent = document.querySelector(".divEvent");
// divEvent.addEventListener("click", (e) => {
//   console.log(e.target);
//   console.log("div clicked");
//   e.target.style.backgroundColor = "red";
// });

// let ele = document.createElement("p");
// ele.textContent = "<p> this is new text";
// divEvent.appendChild(ele);








//___________________________________________________________________
// Books Manager 
let formAddBook = document.querySelector("#add-book-form");
let inputBook = document.querySelector("#book-input");
let checkboxBook = document.querySelector("#hide-books");
let ulBook = document.querySelector("#book-list");

formAddBook.addEventListener("submit", (e) => {
  e.preventDefault();
  let userInput = inputBook.value.trim();

  if (userInput !== "") {
    let li = document.createElement("li");
    li.className = "book-item";

    let spn = document.createElement("span");
    spn.textContent = userInput;
    spn.className = "name";

    let btn = document.createElement("button");
    btn.textContent = "Delete";
    btn.className = "btn btn-danger btn-sm delete-book";

    li.appendChild(spn);
    li.appendChild(btn);
    ulBook.appendChild(li);

    inputBook.value = "";
    inputBook.focus();
  }
});

ulBook.addEventListener("click", (e) => {
  if (e.target.classList.contains("delete-book")) {
    e.target.parentElement.remove();
  }
});

checkboxBook.addEventListener("change", (e) => {
  if (e.target.checked) {
    ulBook.style.display = "none";
  } else {
    ulBook.style.display = "block";
  }
});




//___________________________________________________________________
// To-Do List Manager
let formAddTodo = document.querySelector("#add-todo-form");
let inputTodo = document.querySelector("#todo-input");
let ulTodo = document.querySelector("#todo-list");

// Add todo 
formAddTodo.addEventListener("submit", (e) => {
  e.preventDefault();
  let userInput = inputTodo.value.trim();

  if (userInput !== "") {
    let li = document.createElement("li");
    li.className = "todo-item";

    // Checkbox for completion
    let checkbox = document.createElement("input");
    checkbox.type = "checkbox";
    checkbox.className = "todo-check";

    // Todo text
    let spn = document.createElement("span");
    spn.textContent = userInput;
    spn.className = "todo-text";

    // Actions 
    let actionsDiv = document.createElement("div");
    actionsDiv.className = "todo-actions";

    // Edit button
    let editBtn = document.createElement("button");
    editBtn.textContent = "Edit";
    editBtn.className = "btn btn-warning btn-sm edit-todo";

    // Delete button
    let deleteBtn = document.createElement("button");
    deleteBtn.textContent = "Delete";
    deleteBtn.className = "btn btn-danger btn-sm delete-todo";

    // Assemble the todo item
    actionsDiv.appendChild(editBtn);
    actionsDiv.appendChild(deleteBtn);

    li.appendChild(checkbox);
    li.appendChild(spn);
    li.appendChild(actionsDiv);

    ulTodo.appendChild(li);

    inputTodo.value = "";
    inputTodo.focus();
  }
});

// Todo list event handling
ulTodo.addEventListener("click", (e) => {
  let todoItem = e.target.closest(".todo-item");

  // Toggle complete
  if (
    e.target.classList.contains("todo-check") ||
    e.target.classList.contains("todo-text")
  ) {
    let todoText = todoItem.querySelector(".todo-text");
    todoText.classList.toggle("completed");
  }

  // Delete todo
  if (e.target.classList.contains("delete-todo")) {
    todoItem.remove();
  }

  // Edit todo
  if (e.target.classList.contains("edit-todo")) {
    let todoText = todoItem.querySelector(".todo-text");
    let currentText = todoText.textContent;

    let input = document.createElement("input");
    input.type = "text";
    input.className = "form-control";
    input.value = currentText;

    todoText.replaceWith(input);
    input.focus();

    // Save on Enter key
    input.addEventListener("keypress", function (evt) {
      if (evt.key === "Enter") {
        let newText = input.value.trim();
        if (newText !== "") {
          let newSpan = document.createElement("span");
          newSpan.textContent = newText;
          newSpan.className = "todo-text";
          if (todoItem.querySelector(".todo-check").checked) {
            newSpan.classList.add("completed");
          }
          input.replaceWith(newSpan);
        }
      }
    });

    // Save on blur (clicking away)
    input.addEventListener("blur", function () {
      let newText = input.value.trim();
      if (newText !== "") {
        let newSpan = document.createElement("span");
        newSpan.textContent = newText;
        newSpan.className = "todo-text";
        if (todoItem.querySelector(".todo-check").checked) {
          newSpan.classList.add("completed");
        }
        input.replaceWith(newSpan);
      }
    });
  }
});
