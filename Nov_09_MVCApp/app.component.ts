import { Component } from '@angular/core';
import { FormControl } from '@angular/forms';  

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'angularForms';
  email = new FormControl('');  
  name = new FormControl(' ');
  pwd = new FormControl(' ');
  update() {  
    this.name.setValue('Aishwarya');
    this.email.setValue('aishwarya.jadhav@dxc.com');  
    this.pwd.setValue('aishu@1234');
}
}