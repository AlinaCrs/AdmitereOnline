/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { FacultatiComponent } from './facultati.component';

describe('FacultatiComponent', () => {
  let component: FacultatiComponent;
  let fixture: ComponentFixture<FacultatiComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FacultatiComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FacultatiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
