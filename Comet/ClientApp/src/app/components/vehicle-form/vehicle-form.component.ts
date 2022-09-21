import { Component, OnInit } from '@angular/core';
import { MakeService } from 'src/app/services/make.service';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {
  makes : any;
  constructor(private makeService: MakeService) { }

  ngOnInit(): void {
    this.makeService.getMakes().subscribe(makes => {
      this.makes = makes
      console.log("MAKES", this.makes);
    });

  }

}
