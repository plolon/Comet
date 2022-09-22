import { Component, OnInit } from '@angular/core';
import { FeatureService } from 'src/app/services/feature.service';
import { MakeService } from 'src/app/services/make.service';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css'],
})
export class VehicleFormComponent implements OnInit {
  makes: any = [];
  features: any = [];
  models: any = [];
  vehicle: any = {};
  constructor(
    private makeService: MakeService,
     private featureService : FeatureService) {}

  ngOnInit(): void {
    this.makeService.getMakes().subscribe((makes) => {
      this.makes = makes;
    });

    this.featureService.getFeatures().subscribe((features) => {
      this.features = features;
    });
  }

  onMakeChange() {
    var selectedMake = this.makes.find((m: any) => m.id == this.vehicle.make);
    this.models = selectedMake ? selectedMake.models : [];
  }
}
