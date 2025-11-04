function showType() {
        let input = document.getElementById("userInput").value;
        let value, type;

        if (input === "true" || input === "false") 
        {
            value = (input === "true");  
        } 
        else if (input.trim() === "") 
        {
            value = undefined;
        } 
        else if (!isNaN(input)) 
        {
            value = Number(input);       
        } 
        else 
        {
            value = input;               
        }

        type = typeof value;
        output.innerText = `You typed: ${value} Type detected: ${type}`;
      }

      function showSum()
      {
        let num1=parseInt(document.getElementById("num1").value)
        let num2=parseInt(document.getElementById("num2").value)
        let output = document.getElementById("result");
        output.innerText= `Sum of ${num1} and  ${num2} is ${num1 +num2}`
      }

      function showMessage()
      {
        let msg=document.getElementById("message")

        if(msg.style.display === "none")
        {
           msg.style.display = "block";
        }
        else
        {
            msg.style.display = "none";
        }
      }
      let colors = [];

      function AddColor() {
        const input = document.getElementById("inputColor");
        const list = document.getElementById("colorList");
        const color = input.value.trim();

        if (color === "") return; 

        colors.push(color);
        input.value = "";

        list.innerText = "Your Favourite Colors : " + colors.join(", ");
      }
      function changeColor(color) {
        document.body.style.backgroundColor = color;
      }
      function showStudent()
      {
        const name = document.getElementById("name").value.trim();
        const age = document.getElementById("age").value.trim();
        const grade = document.getElementById("grade").value.trim();

        const student = {
          name: name,
          age: age,
          grade: grade
        };

        const infoDiv = document.getElementById("studentInfo");
        infoDiv.innerHTML = `
          <strong>Student Details:</strong><br>
          Name: ${student.name}<br>
          Age: ${student.age}<br>
          Grade: ${student.grade}
        `;
      }
      