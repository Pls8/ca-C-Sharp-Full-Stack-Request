let User = [
    {id:1, name:"name1", password: 123, phone:9999, balance:50},
    {id:2, name:"name2", password: 123, phone:8888, balance:50},
    {id:3, name:"name3", password: 123, phone:7777, balance:50},
    {id:4, name:"name4", password: 123, phone:6666, balance:50},
    {id:5, name:"name5", password: 123, phone:5555, balance:50},
];

let inName = prompt("Enter your name: ");
let inPassword = Number(prompt("Enter your password")); 

//const checkUser = (name, password) =>
function checkUser(name, password){
    for(let i = 0; i < User.length; i++){
        if(User[i].name == name && User[i].password == password){
            return User[i];
        }
    }
    alert("User not found");
    return false;
}

let login = checkUser(inName, inPassword);
if(login){
    let userinput = prompt("Do you want to 1.withdraw or 2.deposit?");
    switch(userinput){
        case "1":
            let withdrawAmount = Number(prompt("Enter amount"));
            //let withdrawAmount = parseFloat(prompt("Enter amount"));
            if(withdrawAmount > login.balance){
                alert("Insufficient balance");
                break;
            }
            login.balance -= withdrawAmount;
            alert(`Withdrawal successful! New balance: ${login.balance}.OMR`);
            break;
        case "2":
            let depositAmount = Number(prompt("Enter amount")); 
            login.balance += depositAmount;
            alert(`Deposit successful! New balance: ${login.balance}.OMR`);
            break;
        default:
            alert("Invalid input");
            break;
    }
} else {
    alert("Login failed!");
}


