import { Component, OnInit } from '@angular/core';
import { VehicleService } from 'src/app/services/vehicle.service';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css'],
})
export class VehicleFormComponent implements OnInit {

  makes: any = [];
  features: any = [];
  models: any = [];
  vehicle: any = {
    features: [],
    contact: {}
  };

  constructor(private vehicleService: VehicleService) {}

  ngOnInit(): void {
    this.vehicleService.getMakes().subscribe((makes) => {
      this.makes = makes;
    });
    this.vehicleService.getFeatures().subscribe((features) => {
      this.features = features;
    });
  }

  onMakeChange() {
    var selectedMake = this.makes.find((m: any) => m.id == this.vehicle.makeId);
    this.models = selectedMake ? selectedMake.models : [];
  }

  onFeatureToggle(featureId: number, $event: any) {
    if($event.target.checked) {
      this.vehicle.features.push(featureId);
    } else {
      var index = this.vehicle.features.indexOf(featureId);
      this.vehicle.features.splice(index, 1);
    }
  }

  onSubmit() {
    this.vehicle.isRegistered = this.vehicle.isRegistered == "true" ? true : false;
    this.vehicleService.create(this.vehicle)
    .subscribe(
      data => console.log(data),
      err => {
        
      });
  }
}
