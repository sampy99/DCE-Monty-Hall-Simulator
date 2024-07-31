
import { Component, NgModule } from '@angular/core';
import { SimulationService } from '../simulation.service';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-game',
  standalone: true,
  imports: [FormsModule, HttpClientModule, CommonModule ],
  templateUrl: './simulation.component.html',
  styleUrl: './simulation.component.css'
})
export class SimulationComponent {
  numSimulations : any;
  switchDoor = true;
  result: any = null;

  constructor(private simulationService: SimulationService) {}

  runSimulation() {
    this.simulationService.runSimulation({
      numSimulations: this.numSimulations,
      switchDoor: this.switchDoor
    }).subscribe(result => {
      this.result = result;
    });
  }
}
