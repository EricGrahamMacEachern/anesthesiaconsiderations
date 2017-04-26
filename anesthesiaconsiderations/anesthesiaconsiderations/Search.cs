using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Linq;

namespace FormsGallery
{

    public class pageList
    {
        public pageList(string pageTitle, Type fileName)
        {
            this.pageTitle = pageTitle;
            this.fileName = fileName;
        }

        public string pageTitle { private set; get; }

        public Type fileName { private set; get; }

    };

    class DetailPage : ContentPage
    {
        public DetailPage(pageList page_list)
        {
            this.page_list = page_list;
        }

        public pageList page_list { private set; get; }

    }

    class Search : ContentPage
    {
        Label resultsLabel;
        Xamarin.Forms.SearchBar searchBar;

        ObservableCollection<pageList> pageListings = new ObservableCollection<pageList>
{
new pageList("Abdominal Aortic Aneurysm Repair (Open)", typeof(AbdominalAorticAneurysmRepairOpen)),
new pageList("Abdominal Compartment Syndrome", typeof(AbdominalCompartmentSyndrome)),
new pageList("Acetaminophen Overdose", typeof(AcetaminophenOverdose)),
new pageList("Achondroplasia", typeof(Achondroplasia)),
new pageList("Acromegaly", typeof(Acromegaly)),
new pageList("Acute Leukemia", typeof(AcuteLeukemia)),
new pageList("Acute Renal Failure", typeof(AcuteRenalFailure)),
new pageList("Acute Spinal Cord Injury", typeof(AcuteSpinalCordInjury)),
new pageList("Adrenocortical Insufficiency", typeof(AdrenocorticalInsufficiency)),
new pageList("Adult Congenital Heart Disease", typeof(AdultCongenitalHeartDisease)),
new pageList("Airway", typeof(Airway)),
new pageList("Airway Abscess and Infection", typeof(AirwayAbscessAndInfection)),
new pageList("Airway Fire", typeof(AirwayFire)),
new pageList("Airway Foreign Body", typeof(AirwayForeignBody)),
new pageList("Alcoholism", typeof(Alcoholism)),
new pageList("Amniotic Fluid Embolism", typeof(AmnioticFluidEmbolism)),
new pageList("Amyloidosis", typeof(Amyloidosis)),
new pageList("Amyotrophic Lateral Sclerosis ALS", typeof(AmyotrophicLateralSclerosisALS)),
new pageList("Anaphylaxis", typeof(Anaphylaxis)),
new pageList("Anaphylaxis", typeof(Anaphylaxis)),
new pageList("Aneurism Coiling", typeof(AneurismCoiling)),
new pageList("Ankylosing Spondylitis", typeof(AnkylosingSpondylitis)),
new pageList("Anorexia Nervosa", typeof(AnorexiaNervosa)),
new pageList("Antepartum Hemorrhage", typeof(AntepartumHemorrhage)),
new pageList("Anterior Mediastinal Mass", typeof(AnteriorMediastinalMass)),
new pageList("Aortic Dissection", typeof(AorticDissection)),
new pageList("Aortic Regurgitation", typeof(AorticRegurgitation)),
new pageList("Aoritic Stenosis", typeof(AorticStenosis)),
new pageList("ARDS - Acute Respiratory Distress Syndrome", typeof(ARDS)),
new pageList("Arnold Chiari Malformation", typeof(ArnoldChiariMalformation)),
new pageList("ASA toxicity", typeof(ASAToxicity)),
new pageList("Asthma", typeof(Asthma)),
new pageList("Atrial Fibrillation", typeof(AtrialFibrilation)),
new pageList("Atrial Septal Defect", typeof(AtrialSeptalDefect)),
new pageList("Autonomic Hyperrreflexia", typeof(AutonomicHyperreflexia)),
new pageList("Beta Blocker Overdose", typeof(BetaBlockerOverdose)),
new pageList("Breech Presentation", typeof(BreechPresentation)),
new pageList("Bronchietasis", typeof(Bronchiectasis)),
new pageList("Bronchopleural Fistula", typeof(BronchopleuralFistula)),
new pageList("Bronchospasm", typeof(Bronchospasm)),
new pageList("Brugada Syndrome", typeof(BrugudaSyndrome)),
new pageList("Bullous Lung Disease", typeof(BullousLungDisease)),
new pageList("Burns", typeof(Burns)),
new pageList("Carcinoid", typeof(Carcinoid)),
new pageList("Cardiac", typeof(Cardiac)),
new pageList("Cardiac Contusion", typeof(CardiacContusion)),
new pageList("Cardiac Tamponade", typeof(CardiacTamponade)),
new pageList("Cardiomyopathies", typeof(Cardiomyopathies)),
new pageList("Carotid Endarterectomy", typeof(CarotidEndarterectomy)),
new pageList("Cerebral Palsy", typeof(CerebralPalsy)),
new pageList("Cervical Cerclage", typeof(CervicalCerclage)),
new pageList("Chronic Renal Failure", typeof(ChronicRenalFailure)),
new pageList("Cleft Lip and Palate", typeof(CleftLipAndPalate)),
new pageList("Cocaine Toxicity", typeof(CocaineToxicity)),
new pageList("Congenital Diaphragmatic Hernia", typeof(CongenitalDiaphragmaticHernia)),
new pageList("COPD", typeof(COPD)),
new pageList("Coronary Artery Disease", typeof(CoronaryArteryDisease)),
new pageList("Craniofacial Dysostosis", typeof(CraniofacialDysostosis)),
new pageList("Craniotomy", typeof(Craniotomy)),
new pageList("Chronic Renal Failure", typeof(ChronicRenalFailure)),
new pageList("Croup Laryngotacheobronchitis", typeof(CroupLaryngotracheobronchitis)),
new pageList("Crush Injuries", typeof(CrushInjuries)),
new pageList("Cushing's Syndrome", typeof(CushingsSyndrome)),
new pageList("Cyanide Toxicity", typeof(CyanideToxicity)),
new pageList("Cystic Fibrosis", typeof(CysticFibrosis)),
new pageList("Delayed Emergence", typeof(DelayedEmergence)),
new pageList("Diabetes Insipidus", typeof(DiabetesInsipidus)),
new pageList("Diabetes Melitus", typeof(DiabetesMellitus)),
new pageList("Diabetic Ketoacidosis", typeof(DiabeticKetoacidosis)),
new pageList("Digoxin Toxicity", typeof(DigoxinToxicity)),
new pageList("Disseminated Intravascular Coagulation DIC", typeof(DisseminatedIntravascularCoagulationDIC)),
new pageList("Down Syndrome", typeof(DownSyndrome)),
new pageList("Drowning", typeof(Drowning)),
new pageList("Duchenne Muscular Dystrophy", typeof(DuchenneMuscularDystrophy)),
new pageList("Dyspnea in Pregnancy", typeof(DyspnealnPregnancy)),
new pageList("Ehlers Danlos", typeof(EhlersDanlos)),
new pageList("Electroconvulsive Therapy ECT", typeof(ElectroconvulsiveTherapyECT)),
new pageList("End Stage Liver Disease", typeof(Cirrhosis)),
new pageList("Endocrinology", typeof(Endocrinology)),
new pageList("Epiglottitis", typeof(Epiglottitis)),
new pageList("Esophagectomy", typeof(Esophagectomy)),
new pageList("Expanding Neck Hematoma", typeof(ExpandingNeckHematoma)),
new pageList("External Cephalic Version", typeof(ExternalCephalicVersion)),
new pageList("Extravasation Injuries", typeof(ExtravasationInjuries)),
new pageList("Fat Embolism", typeof(FatEmbolism)),
new pageList("Fetal Distress", typeof(FetalDistress)),
new pageList("Fontan Physiology", typeof(FontanPhysiology)),
new pageList("Former Premature Infant", typeof(FormerPrematureInfant)),
new pageList("G6D Deficiency", typeof(G6PDDeficiency)),
new pageList("Glycogen Storage Disorders", typeof(GlycogenStorageDisorders)),
new pageList("Guillain-Barre Syndrome GBS", typeof(GuillainBarreSyndromeGBS)),
new pageList("Hemophilia", typeof(Hemophilia)),
new pageList("Hereditary Angioedema C1 Esterase Deficiency", typeof(HereditaryAngioedemaC1EsteraseDeficiency)),
new pageList("Hereditary Hemorrhagic Telangiectasias", typeof(HereditaryHemorrhagicTelangiectasias)),
new pageList("Huntington Disease", typeof(HuntingtonsDisease)),
new pageList("Hyperaldosteronism", typeof(Hyperaldosteronism)),
new pageList("Hyperkalemia", typeof(Hyperkalemia)),
new pageList("Hypertension", typeof(Hypertension)),
new pageList("Hyperthyroidism Thyroid Storm", typeof(HyperthyroidismThyroidStorm)),
new pageList("Hypertrophic Obstructive Cardiomyopathy", typeof(HypertrophicObstructiveCardiomyopathy)),
new pageList("Hypoglycemia", typeof(Hypoglycemia)),
new pageList("Hyponatremia", typeof(Hyponatremia)),
new pageList("Hypotension", typeof(Hypotension)),
new pageList("Hypothyroidism", typeof(Hypothyroidism)),
new pageList("Hypoxemia", typeof(Hypoxemia)),
new pageList("Increased Airway Pressure", typeof(IncreasedAirwayPressure)),
new pageList("Infective Endocardtis Prophylaxis", typeof(InfectiveEndocarditisProphylaxis)),
new pageList("Jehova's Witness Patients", typeof(JehovasWitnessPatients)),
new pageList("Local Anesthetic Toxicity", typeof(LocalAnestheticToxicity)),
new pageList("Malignant Hyperthermia", typeof(MalignantHyperthermia)),
new pageList("Marfan's Syndrome", typeof(MarfansSyndrome)),
new pageList("Massive Hemoptysis", typeof(MassiveHemoptysis)),
new pageList("MDMA Ecstasy", typeof(MDMAEcstasy)),
new pageList("Mediastinoscopy", typeof(Mediastinoscopy)),
new pageList("Methamphetamines", typeof(Methamphetamines)),
new pageList("Microlaryngoscopy and Airway Laser", typeof(MicrolaryngoscopyAndAirwayLaser)),
new pageList("Mitral Regurgitation", typeof(MitralRegurgitation)),
new pageList("Mitral Stenosis", typeof(MitralStenosis)),
new pageList("MOAI Monoamine Oxidase Inhibitors", typeof(MOAIMonoamineOxidaseInhibitors)),
new pageList("Mucopolysaccharidosis", typeof(Mucopolysaccharidosis)),
new pageList("Multiple Gestation", typeof(MultipleGestation)),
new pageList("Multiple Sclerosis", typeof(MultipleSclerosis)),
new pageList("Myasthenia Gravis", typeof(MyastheniaGravis)),
new pageList("Myasthenic Eaton Lambert Syndrome", typeof(MyasthenicEatonLambertSyndrome)),
new pageList("MyotonicDystrophy", typeof(MyotonicDystrophy)),
new pageList("Necrotizing Enterocolitis", typeof(NecrotizingEnterocolitis)),
new pageList("Neuroanesthesia", typeof(Neuroanesthesia)),
new pageList("Neurofibromatosis", typeof(Neurofibromatosis)),
new pageList("Neuroleptic Malignant Syndrome", typeof(NeurolepticMalignantSyndrome)),
new pageList("Non Obstetric Surgery in Pregnancy", typeof(NonObstetricalSurgeryInPregnancy)),
new pageList("Obesity", typeof(Obesity)),
new pageList("Obstructive Sleep Apnea", typeof(ObstructiveSleepApnea)),
new pageList("Omphalocele and Gastroschisis", typeof(OmphaloceleAndGastroschisis)),
new pageList("Organ Donation", typeof(OrganDonation)),
new pageList("Organophosphates", typeof(Organophosphates)),
new pageList("Osteogenesis Imperfecta", typeof(OsteogenesisImperfecta)),
new pageList("Pacemanker and ICDs", typeof(PacemakerAndICDs)),
new pageList("Parkinson's Disease", typeof(PacemakerAndICDs)),
new pageList("Pediatric Patient", typeof(PediatricPatient)),
new pageList("Penetrating Neck Injuries", typeof(PenetratingNeckInjuries)),
new pageList("Periodic Paralysis", typeof(PeriodicParalysis)),
new pageList("Perioperative MI", typeof(PerioperativeMI)),
new pageList("Perioperative Steroids", typeof(PerioperativeSteroids)),
new pageList("Peripartum Cardiac Arrest", typeof(PeripartumCardiacArrest)),
new pageList("Peripartum Cardiomyopathy", typeof(PeripartumCardiomyopathy)),
new pageList("Pheochromacytoma", typeof(Pheochromocytoma)),
new pageList("Pierre Robin Syndrome", typeof(PierreRobinSyndrome)),
new pageList("Pituitary Surger", typeof(PituitarySurgery)),
new pageList("Placental Abruption", typeof(PlacentalAbruption)),
new pageList("Pneumonectomy", typeof(Pneumonectomy)),
new pageList("Polymyositis and Dermatomyositis", typeof(PolymyositisAndDermatomyositis)),
new pageList("Porphyria", typeof(Porphyria)),
new pageList("Posterior Fossa Surgery", typeof(PosteriorFossaSurgery)),
new pageList("Post Lung Transplant", typeof(PostLungTransplant)),
new pageList("Postopertaive Visual Loss", typeof(PostoperativeVisualLoss)),
new pageList("Postpartum Hemorrhage", typeof(PostpartumHemorrhage)),
new pageList("Preeclampsia", typeof(Preeclampsia)),
new pageList("Premature Infant", typeof(PrematureInfant)),
new pageList("Psychiatric", typeof(Psychiatric)),
new pageList("Pulmonary Embolism", typeof(PulmonaryEmbolism)),
new pageList("Pulmonary Hypertension", typeof(PulmonaryHypertension)),
new pageList("Pyloric Stenosis", typeof(PyloricStenosis)),
new pageList("QT Prolongation", typeof(QTProlongation)),
new pageList("Rare Coexisting Disease", typeof(RareCoexistingDisease)),
new pageList("Respiratory and Thoracics", typeof(RespiratoryAndThoracics)),
new pageList("Restrictive Lung Disease", typeof(RestrictiveLungDisease)),
new pageList("Rheumatoid Arthritis", typeof(RheumatoidArthritis)),
new pageList("Rigid Bronchoscopy", typeof(RigidBronchoscopy)),
new pageList("Scleroderma", typeof(Scleroderma)),
new pageList("Scoliosis", typeof(Scoliosis)),
new pageList("Seizure", typeof(Seizure)),
new pageList("Sepsis", typeof(Sepsis)),
new pageList("Serptpmom Syndrome", typeof(SerotoninSyndrome)),
new pageList("SIADH", typeof(SIADH)),
new pageList("Sickle Cell Disease", typeof(SickleCellDisease)),
new pageList("Skin and Musculoskeletal", typeof(SkinAndMusculoskeletal)),
new pageList("Smoke Inhalation", typeof(SmokeInhalation)),
new pageList("Smoking", typeof(Smoking)),
new pageList("Spina Bifida", typeof(SpinaBifida)),
new pageList("Spine Surgery", typeof(SpineSurgery)),
new pageList("Steven Johnson Syndrome", typeof(StevenJohnsonSyndrome)),
new pageList("Subarachnoid Hemorrhage", typeof(SubarachnoidHemorrhage)),
new pageList("Systemic Lupus Erythematosus SLE", typeof(SystemicLupusErythematosusSLE)),
new pageList("Tetralogy of Fallout", typeof(TetralogyOfFallout)),
new pageList("Thalassemia", typeof(Thalassemia)),
new pageList("Thymectomy", typeof(Thymectomy)),
new pageList("Total Spinal", typeof(TotalSpinal)),
new pageList("Toxicities", typeof(Toxicities)),
new pageList("Tracheosophageal Fistula", typeof(TracheosophagealFistula)),
new pageList("Tracheostomy", typeof(Tracheostomy)),
new pageList("Transfusion Reactions", typeof(TransfusionReactions)),
new pageList("Transplanted Heart", typeof(TransplantedHeart)),
new pageList("Trauma", typeof(Trauma)),
new pageList("Traumatic Brain Injury", typeof(TraumaticBrainInjury)),
new pageList("Tricuspid Regurgitation", typeof(TricuspidRegurgitation)),
new pageList("Tricyclic Antidepressants TCA", typeof(TricyclicAntidepressantsTCA)),
new pageList("Tumor Lysis Syndrome", typeof(TumorLysisSyndrome)),
new pageList("TURP and TURP Syndrome", typeof(TURPAndTURPSyndrome)),
new pageList("Uterine Inversion", typeof(UterineInversion)),
new pageList("Venous Air Embolism", typeof(VenousAirEmbolism)),
new pageList("Von Willebrand's Disease", typeof(VonWillebrandsDisease)),
new pageList("Wegeners Granulamatosis", typeof(WegenersGranulomatosis)),
new pageList("Wolff-Parkinson-White Syndrome", typeof(WolffParkinsonWhiteSyndrome)),
};
        ObservableCollection<pageList> _viewModels = new ObservableCollection<pageList>
{
new pageList("Abdominal Aortic Aneurysm Repair (Open)", typeof(AbdominalAorticAneurysmRepairOpen)),
new pageList("Abdominal Compartment Syndrome", typeof(AbdominalCompartmentSyndrome)),
new pageList("Acetaminophen Overdose", typeof(AcetaminophenOverdose)),
new pageList("Achondroplasia", typeof(Achondroplasia)),
new pageList("Acromegaly", typeof(Acromegaly)),
new pageList("Acute Leukemia", typeof(AcuteLeukemia)),
new pageList("Acute Renal Failure", typeof(AcuteRenalFailure)),
new pageList("Acute Spinal Cord Injury", typeof(AcuteSpinalCordInjury)),
new pageList("Adrenocortical Insufficiency", typeof(AdrenocorticalInsufficiency)),
new pageList("Adult Congenital Heart Disease", typeof(AdultCongenitalHeartDisease)),
new pageList("Airway", typeof(Airway)),
new pageList("Airway Abscess and Infection", typeof(AirwayAbscessAndInfection)),
new pageList("Airway Fire", typeof(AirwayFire)),
new pageList("Airway Foreign Body", typeof(AirwayForeignBody)),
new pageList("Alcoholism", typeof(Alcoholism)),
new pageList("Amniotic Fluid Embolism", typeof(AmnioticFluidEmbolism)),
new pageList("Amyloidosis", typeof(Amyloidosis)),
new pageList("Amyotrophic Lateral Sclerosis ALS", typeof(AmyotrophicLateralSclerosisALS)),
new pageList("Anaphylaxis", typeof(Anaphylaxis)),
new pageList("Anaphylaxis", typeof(Anaphylaxis)),
new pageList("Ankylosing Spondylitis", typeof(AnkylosingSpondylitis)),
new pageList("Anorexia Nervosa", typeof(AnorexiaNervosa)),
new pageList("Anterior Mediastinal Mass", typeof(AnteriorMediastinalMass)),
new pageList("Aortic Dissection", typeof(AorticDissection)),
new pageList("Aortic Regurgitation", typeof(AorticRegurgitation)),
new pageList("Aoritic Stenosis", typeof(AorticStenosis)),
new pageList("ARDS - Acute Respiratory Distress Syndrome", typeof(ARDS)),
new pageList("Arnold Chiari Malformation", typeof(ArnoldChiariMalformation)),
new pageList("ASA toxicity", typeof(ASAToxicity)),
new pageList("Asthma", typeof(Asthma)),
new pageList("Atrial Fibrillation", typeof(AtrialFibrilation)),
new pageList("Atrial Septal Defect", typeof(AtrialSeptalDefect)),
new pageList("Autonomic Hyperrreflexia", typeof(AutonomicHyperreflexia)),
new pageList("Beta Blocker Overdose", typeof(BetaBlockerOverdose)),
new pageList("Breech Presentation", typeof(BreechPresentation)),
new pageList("Bronchietasis", typeof(Bronchiectasis)),
new pageList("Bronchopleural Fistula", typeof(BronchopleuralFistula)),
new pageList("Bronchospasm", typeof(Bronchospasm)),
new pageList("Brugada Syndrome", typeof(BrugudaSyndrome)),
new pageList("Bullous Lung Disease", typeof(BullousLungDisease)),
new pageList("Burns", typeof(Burns)),
new pageList("Carcinoid", typeof(Carcinoid)),
new pageList("Cardiac", typeof(Cardiac)),
new pageList("Cardiac Contusion", typeof(CardiacContusion)),
new pageList("Cardiac Tamponade", typeof(CardiacTamponade)),
new pageList("Cardiomyopathies", typeof(Cardiomyopathies)),
new pageList("Carotid Endarterectomy", typeof(CarotidEndarterectomy)),
new pageList("Cerebral Palsy", typeof(CerebralPalsy)),
new pageList("Cervical Cerclage", typeof(CervicalCerclage)),
new pageList("Chronic Renal Failure", typeof(ChronicRenalFailure)),
new pageList("Cleft Lip and Palate", typeof(CleftLipAndPalate)),
new pageList("Cocaine Toxicity", typeof(CocaineToxicity)),
new pageList("Congenital Diaphragmatic Hernia", typeof(CongenitalDiaphragmaticHernia)),
new pageList("COPD", typeof(COPD)),
new pageList("Coronary Artery Disease", typeof(CoronaryArteryDisease)),
new pageList("Craniofacial Dysostosis", typeof(CraniofacialDysostosis)),
new pageList("Craniotomy", typeof(Craniotomy)),
new pageList("Chronic Renal Failure", typeof(ChronicRenalFailure)),
new pageList("Croup Laryngotacheobronchitis", typeof(CroupLaryngotracheobronchitis)),
new pageList("Crush Injuries", typeof(CrushInjuries)),
new pageList("Cushing's Syndrome", typeof(CushingsSyndrome)),
new pageList("Cyanide Toxicity", typeof(CyanideToxicity)),
new pageList("Cystic Fibrosis", typeof(CysticFibrosis)),
new pageList("Delayed Emergence", typeof(DelayedEmergence)),
new pageList("Diabetes Insipidus", typeof(DiabetesInsipidus)),
new pageList("Diabetes Melitus", typeof(DiabetesMellitus)),
new pageList("Diabetic Ketoacidosis", typeof(DiabeticKetoacidosis)),
new pageList("Digoxin Toxicity", typeof(DigoxinToxicity)),
new pageList("Disseminated Intravascular Coagulation DIC", typeof(DisseminatedIntravascularCoagulationDIC)),
new pageList("Down Syndrome", typeof(DownSyndrome)),
new pageList("Drowning", typeof(Drowning)),
new pageList("Duchenne Muscular Dystrophy", typeof(DuchenneMuscularDystrophy)),
new pageList("Dyspnea in Pregnancy", typeof(DyspnealnPregnancy)),
new pageList("Ehlers Danlos", typeof(EhlersDanlos)),
new pageList("Electroconvulsive Therapy ECT", typeof(ElectroconvulsiveTherapyECT)),
new pageList("End Stage Liver Disease", typeof(Cirrhosis)),
new pageList("Endocrinology", typeof(Endocrinology)),
new pageList("Epiglottitis", typeof(Epiglottitis)),
new pageList("Esophagectomy", typeof(Esophagectomy)),
new pageList("Expanding Neck Hematoma", typeof(ExpandingNeckHematoma)),
new pageList("External Cephalic Version", typeof(ExternalCephalicVersion)),
new pageList("Extravasation Injuries", typeof(ExtravasationInjuries)),
new pageList("Fat Embolism", typeof(FatEmbolism)),
new pageList("Fetal Distress", typeof(FetalDistress)),
new pageList("Fontan Physiology", typeof(FontanPhysiology)),
new pageList("Former Premature Infant", typeof(FormerPrematureInfant)),
new pageList("G6D Deficiency", typeof(G6PDDeficiency)),
new pageList("Glycogen Storage Disorders", typeof(GlycogenStorageDisorders)),
new pageList("Guillain-Barre Syndrome GBS", typeof(GuillainBarreSyndromeGBS)),
new pageList("Hemophilia", typeof(Hemophilia)),
new pageList("Hereditary Angioedema C1 Esterase Deficiency", typeof(HereditaryAngioedemaC1EsteraseDeficiency)),
new pageList("Hereditary Hemorrhagic Telangiectasias", typeof(HereditaryHemorrhagicTelangiectasias)),
new pageList("Huntington Disease", typeof(HuntingtonsDisease)),
new pageList("Hyperaldosteronism", typeof(Hyperaldosteronism)),
new pageList("Hyperkalemia", typeof(Hyperkalemia)),
new pageList("Hypertension", typeof(Hypertension)),
new pageList("Hyperthyroidism Thyroid Storm", typeof(HyperthyroidismThyroidStorm)),
new pageList("Hypertrophic Obstructive Cardiomyopathy", typeof(HypertrophicObstructiveCardiomyopathy)),
new pageList("Hypoglycemia", typeof(Hypoglycemia)),
new pageList("Hyponatremia", typeof(Hyponatremia)),
new pageList("Hypotension", typeof(Hypotension)),
new pageList("Hypothyroidism", typeof(Hypothyroidism)),
new pageList("Hypoxemia", typeof(Hypoxemia)),
new pageList("Increased Airway Pressure", typeof(IncreasedAirwayPressure)),
new pageList("Infective Endocardtis Prophylaxis", typeof(InfectiveEndocarditisProphylaxis)),
new pageList("LocalAnestheticToxicity", typeof(LocalAnestheticToxicity)),
new pageList("Malignant Hyperthermia", typeof(MalignantHyperthermia)),
new pageList("Marfan's Syndrome", typeof(MarfansSyndrome)),
new pageList("Massive Hemoptysis", typeof(MassiveHemoptysis)),
new pageList("MDMA Ecstasy", typeof(MDMAEcstasy)),
new pageList("Mediastinoscopy", typeof(Mediastinoscopy)),
new pageList("Methamphetamines", typeof(Methamphetamines)),
new pageList("Microlaryngoscopy and Airway Laser", typeof(MicrolaryngoscopyAndAirwayLaser)),
new pageList("Mitral Regurgitation", typeof(MitralRegurgitation)),
new pageList("Mitral Stenosis", typeof(MitralStenosis)),
new pageList("MOAI Monoamine Oxidase Inhibitors", typeof(MOAIMonoamineOxidaseInhibitors)),
new pageList("Mucopolysaccharidosis", typeof(Mucopolysaccharidosis)),
new pageList("Multiple Gestation", typeof(MultipleGestation)),
new pageList("Multiple Sclerosis", typeof(MultipleSclerosis)),
new pageList("Myasthenia Gravis", typeof(MyastheniaGravis)),
new pageList("Myasthenic Eaton Lambert Syndrome", typeof(MyasthenicEatonLambertSyndrome)),
new pageList("MyotonicDystrophy", typeof(MyotonicDystrophy)),
new pageList("Necrotizing Enterocolitis", typeof(NecrotizingEnterocolitis)),
new pageList("Neuroanesthesia", typeof(Neuroanesthesia)),
new pageList("Neurofibromatosis", typeof(Neurofibromatosis)),
new pageList("Neuroleptic Malignant Syndrome", typeof(NeurolepticMalignantSyndrome)),
new pageList("Non Obstetric Surgery in Pregnancy", typeof(NonObstetricalSurgeryInPregnancy)),
new pageList("Obesity", typeof(Obesity)),
new pageList("Obstructive Sleep Apnea", typeof(ObstructiveSleepApnea)),
new pageList("Omphalocele and Gastroschisis", typeof(OmphaloceleAndGastroschisis)),
new pageList("Organ Donation", typeof(OrganDonation)),
new pageList("Organophosphates", typeof(Organophosphates)),
new pageList("Osteogenesis Imperfecta", typeof(OsteogenesisImperfecta)),
new pageList("Pacemanker and ICDs", typeof(PacemakerAndICDs)),
new pageList("Parkinson's Disease", typeof(PacemakerAndICDs)),
new pageList("Pediatric Patient", typeof(PediatricPatient)),
new pageList("Penetrating Neck Injuries", typeof(PenetratingNeckInjuries)),
new pageList("Periodic Paralysis", typeof(PeriodicParalysis)),
new pageList("Perioperative MI", typeof(PerioperativeMI)),
new pageList("Perioperative Steroids", typeof(PerioperativeSteroids)),
new pageList("Peripartum Cardiac Arrest", typeof(PeripartumCardiacArrest)),
new pageList("Peripartum Cardiomyopathy", typeof(PeripartumCardiomyopathy)),
new pageList("Pheochromacytoma", typeof(Pheochromocytoma)),
new pageList("Pierre Robin Syndrome", typeof(PierreRobinSyndrome)),
new pageList("Pituitary Surger", typeof(PituitarySurgery)),
new pageList("Placental Abruption", typeof(PlacentalAbruption)),
new pageList("Pneumonectomy", typeof(Pneumonectomy)),
new pageList("Polymyositis and Dermatomyositis", typeof(PolymyositisAndDermatomyositis)),
new pageList("Porphyria", typeof(Porphyria)),
new pageList("Posterior Fossa Surgery", typeof(PosteriorFossaSurgery)),
new pageList("Post Lung Transplant", typeof(PostLungTransplant)),
new pageList("Postopertaive Visual Loss", typeof(PostoperativeVisualLoss)),
new pageList("Postpartum Hemorrhage", typeof(PostpartumHemorrhage)),
new pageList("Preeclampsia", typeof(Preeclampsia)),
new pageList("Premature Infant", typeof(PrematureInfant)),
new pageList("Psychiatric", typeof(Psychiatric)),
new pageList("Pulmonary Embolism", typeof(PulmonaryEmbolism)),
new pageList("Pulmonary Hypertension", typeof(PulmonaryHypertension)),
new pageList("Pyloric Stenosis", typeof(PyloricStenosis)),
new pageList("QT Prolongation", typeof(QTProlongation)),
new pageList("Rare Coexisting Disease", typeof(RareCoexistingDisease)),
new pageList("Respiratory and Thoracics", typeof(RespiratoryAndThoracics)),
new pageList("Restrictive Lung Disease", typeof(RestrictiveLungDisease)),
new pageList("Rheumatoid Arthritis", typeof(RheumatoidArthritis)),
new pageList("Rigid Bronchoscopy", typeof(RigidBronchoscopy)),
new pageList("Scleroderma", typeof(Scleroderma)),
new pageList("Scoliosis", typeof(Scoliosis)),
new pageList("Seizure", typeof(Seizure)),
new pageList("Sepsis", typeof(Sepsis)),
new pageList("Serptpmom Syndrome", typeof(SerotoninSyndrome)),
new pageList("SIADH", typeof(SIADH)),
new pageList("Sickle Cell Disease", typeof(SickleCellDisease)),
new pageList("Skin and Musculoskeletal", typeof(SkinAndMusculoskeletal)),
new pageList("Smoke Inhalation", typeof(SmokeInhalation)),
new pageList("Smoking", typeof(Smoking)),
new pageList("Spina Bifida", typeof(SpinaBifida)),
new pageList("Spine Surgery", typeof(SpineSurgery)),
new pageList("Steven Johnson Syndrome", typeof(StevenJohnsonSyndrome)),
new pageList("Subarachnoid Hemorrhage", typeof(SubarachnoidHemorrhage)),
new pageList("Systemic Lupus Erythematosus SLE", typeof(SystemicLupusErythematosusSLE)),
new pageList("Tetralogy of Fallout", typeof(TetralogyOfFallout)),
new pageList("Thalassemia", typeof(Thalassemia)),
new pageList("Thymectomy", typeof(Thymectomy)),
new pageList("Total Spinal", typeof(TotalSpinal)),
new pageList("Toxicities", typeof(Toxicities)),
new pageList("Tracheosophageal Fistula", typeof(TracheosophagealFistula)),
new pageList("Tracheostomy", typeof(Tracheostomy)),
new pageList("Transfusion Reactions", typeof(TransfusionReactions)),
new pageList("Transplanted Heart", typeof(TransplantedHeart)),
new pageList("Trauma", typeof(Trauma)),
new pageList("Traumatic Brain Injury", typeof(TraumaticBrainInjury)),
new pageList("Tricuspid Regurgitation", typeof(TricuspidRegurgitation)),
new pageList("Tricyclic Antidepressants TCA", typeof(TricyclicAntidepressantsTCA)),
new pageList("Tumor Lysis Syndrome", typeof(TumorLysisSyndrome)),
new pageList("TURP and TURP Syndrome", typeof(TURPAndTURPSyndrome)),
new pageList("Uterine Inversion", typeof(UterineInversion)),
new pageList("Venous Air Embolism", typeof(VenousAirEmbolism)),
new pageList("Von Willebrand's Disease", typeof(VonWillebrandsDisease)),
new pageList("Wegeners Granulamatosis", typeof(WegenersGranulomatosis)),
new pageList("Wolff-Parkinson-White Syndrome", typeof(WolffParkinsonWhiteSyndrome)),
};

        public Search()
        {
            BackgroundColor = Color.White;

            Label header = new Label
            {
                Text = "Search",
                TextColor = Color.Black,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
                HorizontalTextAlignment = TextAlignment.Center,
            };

            // Define the page listings. 
            resultsLabel = new Label
            {
                Text = "Result will appear here.",
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.FillAndExpand,
                FontSize = 25
            };

            searchBar = new Xamarin.Forms.SearchBar
            {
                Placeholder = "Enter search term",
                TextColor = Color.Black,
            };

            StackLayout stackLayout = new StackLayout
            {
                VerticalOptions = LayoutOptions.Start,
                Children = {

                    searchBar,
                    new ScrollView
                    {
                        Content = resultsLabel,
                        VerticalOptions = LayoutOptions.FillAndExpand
                    }
                },
            };



            // Create the ListView.
            ListView listView = new ListView
            {



                // Source of data items.
                ItemsSource = pageListings,

                // Define template for displaying each item.
                // (Argument of DataTemplate constructor is called for 
                //      each item; it must return a Cell derivative.)
                ItemTemplate = new DataTemplate(() =>
                {
                    // Create views with bindings for displaying each property
                    Label pageLabel = new Label();

                    pageLabel.SetBinding(Label.TextProperty, "pageTitle");

                    pageLabel.TextColor = Color.Black;



                    return new ViewCell
                    {

                        View = new StackLayout
                        {

                            Padding = new Thickness(0, 5),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new StackLayout
                                {
                                    VerticalOptions = LayoutOptions.Center,

                                    Spacing = 0,
                                    Children =
                                    {
                                        pageLabel,
                                    }
                                }
                            }
                        }
                    };
                })



            };


            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    stackLayout,
                    listView
                }
            };

            searchBar.TextChanged += (sender, e) => Filter(listView, e.NewTextValue);
            searchBar.SearchButtonPressed += (sender, args) => Filter(listView, searchBar.Text);

            listView.ItemTapped += async (sender, args) =>
             {

                 var itemSelected = args.Item as pageList;
                 if (itemSelected != null)
                 {
                     var page = (ContentPage)System.Activator.CreateInstance(itemSelected.fileName);
                     await Navigation.PushAsync(page, true);

                 }

             };




        }

        private void Filter(ListView listView, string newTextValue)
        {
            listView.ItemsSource = string.IsNullOrEmpty(newTextValue)
            ? (IEnumerable<pageList>)pageListings
            : _viewModels.Where(itemSearch => itemSearch.pageTitle.ToLower().Contains(newTextValue.ToLower()))
            .ToList();
        }

    }


}

