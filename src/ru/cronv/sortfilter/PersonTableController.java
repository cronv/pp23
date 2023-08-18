package ru.cronv.sortfilter;

import java.beans.EventHandler;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.collections.transformation.FilteredList;
import javafx.collections.transformation.SortedList;
import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TablePosition;
import javafx.scene.control.TableRow;
import javafx.scene.control.TableView;
import javafx.scene.control.TextField;
import javafx.scene.control.cell.TextFieldTableCell;
import javafx.scene.input.KeyCode;
import javafx.stage.FileChooser;


/**
 * View-Controller for the person table.
 * 
 * @author cronv
 */
public class PersonTableController {
	
	@FXML
	private TextField filterField;
	@FXML
	private Button addButton;
	@FXML
	private Button deleteButton;
	@FXML
	private Button openButton;
	@FXML
	private Button saveButton;
	@FXML
	private TableView<Person> personTable;
	@FXML
	private TableColumn<Person, String> firstNameColumn;
	@FXML
	private TableColumn<Person, String> lastNameColumn;

	private ObservableList<Person> masterData = FXCollections.observableArrayList();

	private TablePosition<Person, ?> lastCell;

	private int lastIndex = 0;

	/**
	 * Just add some sample data in the constructor.
	 */
	public PersonTableController() {
		
		masterData.add(new Person("Hans", "Muster"));
		masterData.add(new Person("Ruth", "Mueller"));
		masterData.add(new Person("Heinz", "Kurz"));
		masterData.add(new Person("Cornelia", "Meier"));
		masterData.add(new Person("Werner", "Meyer"));
		masterData.add(new Person("Lydia", "Kunz"));
		masterData.add(new Person("Anna", "Best"));
		masterData.add(new Person("Stefan", "Meier"));
		masterData.add(new Person("Martin", "Mueller"));
	}

	/**
	 * Initializes the controller class. This method is automatically called
	 * after the fxml file has been loaded.
	 * 
	 * Initializes the table columns and sets up sorting and filtering.
	 */
	@FXML
	private void initialize() {
		// 0. Initialize the columns.
		firstNameColumn.setCellValueFactory(cellData -> cellData.getValue().firstNameProperty());
		lastNameColumn.setCellValueFactory(cellData -> cellData.getValue().lastNameProperty());

		// Allowed edit table
		firstNameColumn.setCellFactory(TextFieldTableCell.forTableColumn());
		lastNameColumn.setCellFactory(TextFieldTableCell.forTableColumn());
		personTable.setEditable(true);
		
		// Обработчик события для сохранения изменений по нажатию клавиши Esc
//		personTable.setOnKeyPressed(event -> {
//		    if (event.getCode() == KeyCode.ESCAPE) {
//		        // Отменить редактирование ячеек
//		        personTable.edit(personTable.getSelectionModel().getSelectedIndex(), null);
//		    }
//		});

		// Обработчик события для сохранения изменений при потере фокуса
		personTable.focusedProperty().addListener((obs, oldVal, newVal) -> {
			if (!newVal) {
		        TablePosition focusedCell = personTable.getFocusModel().getFocusedCell();
		        if (focusedCell != null) {
		            personTable.edit(focusedCell.getRow(), focusedCell.getTableColumn());
		            personTable.getSelectionModel().select(focusedCell.getRow());
		            personTable.getFocusModel().focus(focusedCell.getRow(), focusedCell.getTableColumn());
		        }
		    }
		});
		
		// 1. Wrap the ObservableList in a FilteredList (initially display all data).
		FilteredList<Person> filteredData = new FilteredList<>(masterData, p -> true);
		
		// 2. Set the filter Predicate whenever the filter changes.
		filterField.textProperty().addListener((observable, oldValue, newValue) -> {
			filteredData.setPredicate(person -> {
				// If filter text is empty, display all persons.
				if (newValue == null || newValue.isEmpty()) {
					return true;
				}
				
				// Compare first name and last name of every person with filter text.
				String lowerCaseFilter = newValue.toLowerCase();
				
				if (person.getFirstName().toLowerCase().indexOf(lowerCaseFilter) != -1) {
					return true; // Filter matches first name.
				} else if (person.getLastName().toLowerCase().indexOf(lowerCaseFilter) != -1) {
					return true; // Filter matches last name.
				}
				return false; // Does not match.
			});
		});
		
		// 2.1 Set add row in table (button)
		this.addButton.setOnAction(e -> {
			// Создание нового объекта Person
		    Person person = new Person("", "");
			
			if (masterData.size() == 0) {
			    // Добавление объекта Person в таблицу
			    masterData.add(person);
			    this.setLastRow();
			}
			
			// Check empty row
			Person lastPerson = masterData.get(masterData.size() - 1);
			if (lastPerson.getFirstName().isEmpty() && lastPerson.getLastName().isEmpty()) {
				this.setLastRow();
			    return;
			}
			
		    // Добавление объекта Person в таблицу
		    masterData.add(person);
		    this.setLastRow();
		});
		
		this.deleteButton.setOnAction(e -> {
			if (this.masterData.isEmpty()) {
				return;
			}
			
			Person selectedPerson = this.personTable.getSelectionModel().getSelectedItem();
		    if (selectedPerson != null) {
		        // 3. Remove the selected row from the TableView
		    	masterData.remove(selectedPerson);
		        personTable.getItems().remove(selectedPerson);
		    }
		});
		
		
		this.openButton.setOnAction(e -> this.openFile());
		this.saveButton.setOnAction(e -> this.saveToFile());
		
		
		// 3. Wrap the FilteredList in a SortedList. 
		SortedList<Person> sortedData = new SortedList<>(filteredData);
		
		// 4. Bind the SortedList comparator to the TableView comparator.
		// 	  Otherwise, sorting the TableView would have no effect.
		sortedData.comparatorProperty().bind(personTable.comparatorProperty());
		
		// 5. Add sorted (and filtered) data to the table.
		personTable.setItems(sortedData);
	}
	
	/**
	 * Open data in File
	 */
	private void openFile() {
		FileChooser fileChooser = new FileChooser();
	    fileChooser.setTitle("Open Text File");
	    File file = fileChooser.showOpenDialog(null);
	    
	    if (file != null) {
	        try (BufferedReader br = new BufferedReader(new FileReader(file))) {
	            String line;
	            
	            while ((line = br.readLine()) != null) {
	                String[] data = line.split("\t");
	                String firstName = data[0];
	                String lastName = data[1];
	                
	                Person person = new Person(firstName, lastName);
	                masterData.add(person);
	            }
	            
	            personTable.setItems(masterData);
	        } catch (IOException e) {
	            e.printStackTrace();
	        }
	    }
	}
	
	/**
	 * Save data to File
	 */
	private void saveToFile() {
		FileChooser fileChooser = new FileChooser();
	    fileChooser.setTitle("Save Table Data");
	    fileChooser.getExtensionFilters().add(new FileChooser.ExtensionFilter("Text Files", "*.txt"));
	    File file = fileChooser.showSaveDialog(null);

	    if (file != null) {
	        try (BufferedWriter writer = new BufferedWriter(new FileWriter(file))) {
	            // Write column headers
	            writer.write("First Name" + "\t" + "Last Name");
	            writer.newLine();

	            // Write data for each table row
	            for (Person person : personTable.getItems()) {
	                writer.write(person.getFirstName() + "\t" + person.getLastName());
	                writer.newLine();
	            }

	            writer.flush();
	        } catch (IOException ex) {
	            ex.printStackTrace();
	        }
	    }
	}

	/**
	 * Set last row in TableView
	 */
	private void setLastRow() {
		// Получить последнюю строку таблицы
		this.lastIndex = this.personTable.getItems().size() - 1;
		this.lastCell = new TablePosition<>(this.personTable, this.lastIndex, null);
		// Установить фокус на последнюю строку
		this.personTable.getFocusModel().focus(this.lastCell);
		// Выделить последнюю строку
		this.personTable.getSelectionModel().select(this.lastIndex);
		// Прокрутить таблицу к последней строке
		this.personTable.scrollTo(this.lastIndex);
	}
}
